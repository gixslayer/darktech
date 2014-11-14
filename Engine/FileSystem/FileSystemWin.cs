using System;
using IO = System.IO;
using StringBuilder = System.Text.StringBuilder;

using DarkTech.Engine.Scripting;

namespace DarkTech.Engine.FileSystem
{
    internal sealed class FileSystemWin : IFileSystem
    {
        public const char DIRECTORY_SEPARATOR = '\\';
        public const string DIRECTORY_SEPARATOR_STR = "\\";

        private static readonly string[] ARRAY_EMPTY = new string[0];

        // NOTE: Enforce fs_root does not end with a directory separator.
        private string rootDirectory;

        public FileSystemWin()
        {
            rootDirectory = Engine.ScriptingInterface.GetCvarValue<string>("fs_root");
        }

        public bool DirectoryExists(string path)
        {
            return IO.Directory.Exists(CombinePath(rootDirectory, path));
        }

        public void CreateDirectory(string path)
        {
            try
            {
                IO.Directory.CreateDirectory(CombinePath(rootDirectory, path));
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to create directory {0} > {1}", path, e.Message);
            }
        }

        public void DeleteDirectory(string path)
        {
            try
            {
                IO.Directory.Delete(CombinePath(rootDirectory, path), true);
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to delete directory {0} > {1}", path, e.Message);
            }
        }

        public string[] GetFiles(string path)
        {
            // Get the directory info for the specified path.
            IO.DirectoryInfo directoryInfo;

            try
            {
                directoryInfo = new IO.DirectoryInfo(CombinePath(rootDirectory, path));
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get files in directory {0} > {1}", path, e.Message);

                return ARRAY_EMPTY;
            }

            // If the directory does not exist it will not contain any files.
            if (!directoryInfo.Exists)
            {
                return ARRAY_EMPTY;
            }

            // Get all files inside the top level of the directory.
            IO.FileInfo[] files;

            try
            {
                files = directoryInfo.GetFiles("*", IO.SearchOption.TopDirectoryOnly);
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get files in directory {0} > {1}", path, e.Message);

                return ARRAY_EMPTY;
            }

            // Copy their names into an array.
            string[] fileNames = new string[files.Length];
            int index = 0;

            foreach (IO.FileInfo fileInfo in files)
            {
                fileNames[index++] = fileInfo.Name;
            }

            return fileNames;
        }

        public string[] GetDirectories(string path)
        {
            // Get the directory info for the specified path.
            IO.DirectoryInfo directoryInfo;

            try
            {
                directoryInfo = new IO.DirectoryInfo(CombinePath(rootDirectory, path));
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get directories in directory {0} > {1}", path, e.Message);

                return ARRAY_EMPTY;
            }

            // If the directory does not exist it will not contain any directories.
            if (!directoryInfo.Exists)
            {
                return ARRAY_EMPTY;
            }

            // Get all directories inside the top level of the directory.
            IO.DirectoryInfo[] directories;

            try
            {
                directories = directoryInfo.GetDirectories("*", IO.SearchOption.TopDirectoryOnly);
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get directories in directory {0} > {1}", path, e.Message);

                return ARRAY_EMPTY;
            }
            
            // Copy their names into an array.
            string[] directoryNames = new string[directories.Length];
            int index = 0;

            foreach (IO.DirectoryInfo directory in directories)
            {
                directoryNames[index++] = directory.Name;
            }

            return directoryNames;
        }

        public bool FileExists(string path)
        {
            return IO.File.Exists(CombinePath(rootDirectory, path));
        }

        public void DeleteFile(string path)
        {
            try
            {
                IO.File.Delete(CombinePath(rootDirectory, path));
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to delete file {0} > {1}", path, e.Message);
            }
        }

        public FileInfo GetFileInfo(string path)
        {
            // Get the file info for the specified path.
            IO.FileInfo fileInfo;

            try
            {
                fileInfo = new IO.FileInfo(CombinePath(rootDirectory, path));
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get file info of {0} > {1}", path, e.Message);

                return null;
            }

            // Make sure the file exists.
            if (!fileInfo.Exists)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Could not find file {0}", path);

                return null;
            }

            // Extract the information required.
            string name = fileInfo.Name;
            string extension = fileInfo.Extension;
            string parentPath = fileInfo.DirectoryName;
            long size = fileInfo.Length;

            // Make sure the parentPath is relative to the file system root.
            parentPath = parentPath == rootDirectory ? string.Empty : parentPath.Substring(rootDirectory.Length + 1);

            return new FileInfo(name, extension, parentPath, size);
        }

        public bool OpenFile(string path, FileMode mode, FileAccess access, out File file)
        {
            file = null;

            // Resolve the OpenOrCreate file mode.
            if (mode == FileMode.OpenOrCreate)
            {
                mode = FileExists(path) ? FileMode.Open : FileMode.Create;
            }

            // Convert the file mode and access to the System.IO types.
            IO.FileMode fileMode = ConvertMode(mode);
            IO.FileAccess fileAccess = ConvertAccess(access);

            // Verify the combination of file mode and access is valid.
            if (!VerifyAccess(mode, access))
            {
                return false;
            }

            // Attempt to open the stream.
            IO.Stream stream;

            try
            {
                stream = new IO.FileStream(CombinePath(rootDirectory, path), fileMode, fileAccess);
            }
            catch (Exception e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to open file {0} > {1}", path, e.Message);

                return false;
            }

            // Build the file info.
            FileInfo fileInfo;

            if (mode == FileMode.Open || (mode == FileMode.Append && FileExists(path)))
            {
                fileInfo = GetFileInfo(path);
            }
            else
            {
                fileInfo = CreateFileInfo(path);
            }

            file = new File(fileInfo, stream);

            return true;
        }

        private FileInfo CreateFileInfo(string path)
        {
            string name;
            string extension = string.Empty;
            string parentPath = string.Empty;
            long size = 0;

            string fullPath = CombinePath(rootDirectory, path);
            string relative = fullPath.Substring(rootDirectory.Length + 1);

            if (relative.Contains(DIRECTORY_SEPARATOR_STR))
            {
                name = relative.Substring(relative.LastIndexOf(DIRECTORY_SEPARATOR_STR) + 1);
                parentPath = relative.Substring(0, relative.Length - (name.Length + 1));
            }
            else
            {
                name = relative;
            }

            // A file name should not be able to end with a period.
            if (name.Contains("."))
            {
                extension = name.Substring(name.LastIndexOf(".") + 1);
            }

            return new FileInfo(name, extension, parentPath, size);
        }

        private static IO.FileMode ConvertMode(FileMode mode)
        {
            switch(mode)
            {
                case FileMode.Append:
                    return IO.FileMode.Append;
                case FileMode.Create:
                    return IO.FileMode.CreateNew;
                case FileMode.Open:
                    return IO.FileMode.Open;
                default:
                    throw new ArgumentException("Unknown file mode", "mode");
            }
        }

        private static IO.FileAccess ConvertAccess(FileAccess access)
        {
            switch (access)
            {
                case FileAccess.Read:
                    return IO.FileAccess.Read;
                case FileAccess.ReadWrite:
                    return IO.FileAccess.ReadWrite;
                case FileAccess.Write:
                    return IO.FileAccess.Write;
                default:
                    throw new ArgumentException("Unknown file access", "access");
            }
        }

        private static bool VerifyAccess(FileMode mode, FileAccess access)
        {
            if (mode == FileMode.Append && access != FileAccess.Write)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Invalid access flags on FileMode.Append, only write access is allowed");

                return false;
            }

            if (mode == FileMode.Create && !access.HasFlag(FileAccess.Write))
            {
                Engine.Log.WriteLine("error/system/filesystem", "Missing write access on FileMode.Create");

                return false;
            }

            return true;
        }

        private static string CombinePath(params string[] paths)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string path;

            for (int i = 0; i < paths.Length; i++)
            {
                path = paths[i];

                // Strip path separators.
                path = path.TrimStart(DIRECTORY_SEPARATOR);
                path = path.TrimEnd(DIRECTORY_SEPARATOR);

                // Ignore empty paths.
                if (string.IsNullOrWhiteSpace(path))
                    continue;

                // Append the path and a directory separator to the return value.
                stringBuilder.Append(path);
                stringBuilder.Append(DIRECTORY_SEPARATOR);
            }

            // Strip any tailing directory separators.
            return stringBuilder.ToString().TrimEnd(DIRECTORY_SEPARATOR);
        }
    }
}

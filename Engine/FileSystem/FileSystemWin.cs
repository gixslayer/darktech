using System;
using IO = System.IO;
using StringBuilder = System.Text.StringBuilder;

namespace DarkTech.Engine.FileSystem
{
    internal sealed class FileSystemWin : INativeFileSystem
    {
        public const char DIRECTORY_SEPARATOR = '\\';
        public const string DIRECTORY_SEPARATOR_STR = "\\";

        public bool DirectoryExists(string path)
        {
            return IO.Directory.Exists(path);
        }

        public void CreateDirectory(string path)
        {
            try
            {
                IO.Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
            }
        }

        public void DeleteDirectory(string path)
        {
            try
            {
                IO.Directory.Delete(path, true);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
            }
        }

        public string[] GetFiles(string path)
        {
            // Get the directory info for the specified path.
            // The caller made sure the directory actually exists.
            IO.DirectoryInfo directoryInfo;

            try
            {
                directoryInfo = new IO.DirectoryInfo(path);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
            }

            // Get all files inside the top level of the directory.
            IO.FileInfo[] files;

            try
            {
                files = directoryInfo.GetFiles("*", IO.SearchOption.TopDirectoryOnly);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
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
            // The caller made sure the directory actually exists.
            IO.DirectoryInfo directoryInfo;

            try
            {
                directoryInfo = new IO.DirectoryInfo(path);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
            }

            // Get all directories inside the top level of the directory.
            IO.DirectoryInfo[] directories;

            try
            {
                directories = directoryInfo.GetDirectories("*", IO.SearchOption.TopDirectoryOnly);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
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
            return IO.File.Exists(path);
        }

        public void DeleteFile(string path)
        {
            try
            {
                IO.File.Delete(path);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
            }
        }

        public FileInfo GetFileInfo(string path)
        {
            // Get the file info for the specified path.
            IO.FileInfo fileInfo;

            try
            {
                fileInfo = new IO.FileInfo(path);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
            }

            // Extract the information required.
            string name = fileInfo.Name;
            string extension = fileInfo.Extension;
            string parentPath = fileInfo.DirectoryName;
            long size = fileInfo.Length;

            return new FileInfo(name, extension, parentPath, size);
        }

        public File OpenFile(string path, FileMode mode, FileAccess access)
        {
            // Resolve the OpenOrCreate file mode.
            if (mode == FileMode.OpenOrCreate)
            {
                mode = FileExists(path) ? FileMode.Open : FileMode.Create;
            }

            // Convert the file mode and access to the System.IO types.
            IO.FileMode fileMode = ConvertMode(mode);
            IO.FileAccess fileAccess = ConvertAccess(access);

            // Attempt to open the stream.
            IO.Stream stream;

            try
            {
                stream = new IO.FileStream(path, fileMode, fileAccess);
            }
            catch (Exception e)
            {
                throw new FileSystemException(e.Message);
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

            return new File(fileInfo, stream);
        }

        public string CombinePaths(params string[] paths)
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

        private static FileInfo CreateFileInfo(string path)
        {
            string name = path.Substring(path.LastIndexOf(DIRECTORY_SEPARATOR_STR) + 1);
            string parentPath = path.Substring(0, path.Length - (name.Length + 1));
            string extension = string.Empty;
            long size = 0;

            // A file name should not be able to end with a period.
            if (name.Contains(".") && !name.EndsWith(".") && name.LastIndexOf('.') != 0)
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
    }
}

using System;
using IO = System.IO;

namespace DarkTech.Engine.Resources
{
    public sealed class FileSystemWindows : FileSystem
    {
        private static readonly string[] ARRAY_EMPTY = new string[0];

        // TODO: Assign root to a string Cvar fs_root
        private string root = string.Empty;

        public override bool DirectoryExists(string path)
        {
            return IO.Directory.Exists(CombinePath(root, path));
        }

        public override void CreateDirectory(string path)
        {
            try
            {
                IO.Directory.CreateDirectory(CombinePath(root, path));
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in CreateDirectory > {0}", e.Message);
            }
        }

        public override void DeleteDirectory(string path)
        {
            try
            {
                IO.Directory.Delete(CombinePath(root, path), true);
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in DeleteDirectory > {0}", e.Message);
            }
        }

        public override string[] GetFiles(string path)
        {
            IO.DirectoryInfo directoryInfo;

            try
            {
                directoryInfo = new IO.DirectoryInfo(CombinePath(root, path));
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in GetFiles > {0}", e.Message);

                return ARRAY_EMPTY;
            }

            // If the directory does not exist it will not contain any files. Make this a feature that all implementations must honor.
            if (!directoryInfo.Exists)
            {
                return ARRAY_EMPTY;
            }

            IO.FileInfo[] files = directoryInfo.GetFiles();
            string[] fileNames = new string[files.Length];
            int index = 0;

            foreach (IO.FileInfo fileInfo in files)
            {
                fileNames[index++] = fileInfo.Name;
            }

            return fileNames;
        }

        public override string[] GetDirectories(string path)
        {
            IO.DirectoryInfo directoryInfo;

            try
            {
                directoryInfo = new IO.DirectoryInfo(CombinePath(root, path));
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in GetDirectories > {0}", e.Message);

                return ARRAY_EMPTY;
            }

            // If the directory does not exist it will not contain any sub directories. Make this a feature that all implementations must honor.
            if (!directoryInfo.Exists)
            {
                return ARRAY_EMPTY;
            }

            IO.DirectoryInfo[] directories;

            try
            {
                directories = directoryInfo.GetDirectories();
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in GetDirectories > {0}", e.Message);

                return ARRAY_EMPTY;
            }
            
            string[] directoryNames = new string[directories.Length];
            int index = 0;

            foreach (IO.DirectoryInfo directory in directories)
            {
                directoryNames[index++] = directory.Name;
            }

            return directoryNames;
        }

        public override bool FileExists(string path)
        {
            return IO.File.Exists(CombinePath(root, path));
        }

        public override void DeleteFile(string path)
        {
            try
            {
                IO.File.Delete(CombinePath(root, path));
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in DeleteFile > {0}", e.Message);
            }
        }

        public override FileInfo GetFileInfo(string path)
        {
            IO.FileInfo fileInfo;

            try
            {
                fileInfo = new IO.FileInfo(CombinePath(root, path));
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in GetFileInfo > {0}", e.Message);

                return null;
            }

            if (!fileInfo.Exists)
            {
                Engine.Errorf("Could not find file {0}", path);

                return null;
            }

            string name = fileInfo.Name;
            string extension = fileInfo.Extension;
            string parentPath = fileInfo.DirectoryName;
            long size = fileInfo.Length;

            return new FileInfo(name, extension, parentPath, size);
        }

        public override bool OpenFile(string path, FileMode mode, FileAccess access, out File file)
        {
            file = null;

            if (mode == FileMode.OpenOrCreate)
            {
                mode = FileExists(path) ? FileMode.Open : FileMode.Create;
            }

            IO.FileMode fileMode;
            IO.FileAccess fileAccess;

            switch (mode)
            {
                case FileMode.Create:
                    fileMode = IO.FileMode.CreateNew;
                    if (!access.HasFlag(FileAccess.Write))
                    {
                        Engine.Error("Missing write access on create file");

                        return false;
                    }
                    break;

                case FileMode.Open:
                    fileMode = IO.FileMode.Open;
                    if (!access.HasFlag(FileAccess.Read))
                    {
                        Engine.Error("Missing read access on open file");

                        return false;
                    }
                    break;

                case FileMode.Append:
                    fileMode = IO.FileMode.Append;
                    if (!access.HasFlag(FileAccess.Write))
                    {
                        Engine.Error("Missing write access on append file");

                        return false;
                    }
                    break;

                default:
                    throw new InvalidOperationException("Executing unexpected code");

            }

            switch (access)
            {
                case FileAccess.Read:
                    fileAccess = IO.FileAccess.Read;
                    break;

                case FileAccess.ReadWrite:
                    fileAccess = IO.FileAccess.ReadWrite;
                    break;

                case FileAccess.Write:
                    fileAccess = IO.FileAccess.Write;
                    break;

                default:
                    throw new InvalidOperationException("Executing unexpected code");
            }

            IO.Stream stream;
            string name;
            string extension;
            string parentPath;
            long size;

            try
            {
                stream = new IO.FileStream(CombinePath(root, path), fileMode, fileAccess);
            }
            catch (Exception e)
            {
                Engine.Errorf("Exception in OpenFile > {0}", e.Message);

                return false;
            }

            if (mode == FileMode.Create)
            {
                if (path.Contains(DIRECTORY_SEPARATOR.ToString()))
                {
                    name = path.Substring(path.LastIndexOf(DIRECTORY_SEPARATOR) + 1);
                    parentPath = path.Substring(0, path.LastIndexOf(DIRECTORY_SEPARATOR));
                }
                else
                {
                    name = path;
                    parentPath = string.Empty;
                }

                size = 0;

                if (name.Contains(".") && !name.EndsWith("."))
                {
                    extension = name.Substring(name.LastIndexOf(".") + 1);
                }
                else
                {
                    extension = string.Empty;
                }
            }
            else
            {
                FileInfo fileInfo = GetFileInfo(path);

                name = fileInfo.Name;
                extension = fileInfo.Extension;
                parentPath = fileInfo.ParentPath;
                size = fileInfo.Size;
            }

            file = new File(name, extension, parentPath, size, stream);

            return true;
        }

        public override void CloseFile(File file)
        {
            if (file == null)
            {
                throw new ArgumentNullException("file");
            }

            file.Stream.Close();
        }
    }
}

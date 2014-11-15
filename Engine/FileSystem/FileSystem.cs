namespace DarkTech.Engine.FileSystem
{
    public sealed class FileSystem
    {
        private readonly INativeFileSystem nativeFileSystem;
        private readonly string fs_root;

        internal FileSystem()
        {
            this.nativeFileSystem = Platform.CreateNativeFileSystem();
            this.fs_root = Engine.ScriptingInterface.GetCvarValue<string>("fs_root");
        }

        public bool DirectoryExists(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);
            
            if (string.IsNullOrWhiteSpace(path))
                throw new System.ArgumentException("Path cannot be empty", "path");
            if (!nativeFileSystem.IsPathValid(actualPath, false))
                throw new InvalidPathException(actualPath);

            try
            {
                return nativeFileSystem.DirectoryExists(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to check if directory {0} exists ({1})", path, e.Message);

                return false;
            }
        }

        public void CreateDirectory(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (string.IsNullOrWhiteSpace(path))
                throw new System.ArgumentException("Path cannot be empty", "path");
            if (!nativeFileSystem.IsPathValid(actualPath, false))
                throw new InvalidPathException(actualPath);

            try
            {
                nativeFileSystem.CreateDirectory(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to create directory {0} ({1})", path, e.Message);
            }
        }

        public void DeleteDirectory(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (string.IsNullOrWhiteSpace(path))
                throw new System.ArgumentException("Path cannot be empty", "path");
            if (!nativeFileSystem.IsPathValid(actualPath, false))
                throw new InvalidPathException(actualPath);

            try
            {
                nativeFileSystem.DeleteDirectory(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to delete directory {0} ({1})", path, e.Message);
            }
        }

        public string[] GetDirectories(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (!nativeFileSystem.IsPathValid(actualPath, false))
                throw new InvalidPathException(actualPath);

            try
            {
                if (!nativeFileSystem.DirectoryExists(path))
                {
                    return new string[0];
                }

                return nativeFileSystem.GetDirectories(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get directories in directory {0} ({1})", path, e.Message);

                return new string[0];
            }
        }

        public string[] GetFiles(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (!nativeFileSystem.IsPathValid(actualPath, false))
                throw new InvalidPathException(actualPath);

            try
            {
                if (!nativeFileSystem.DirectoryExists(actualPath))
                {
                    return new string[0];
                }

                return nativeFileSystem.GetFiles(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get files in directory {0} ({1})", path, e.Message);

                return new string[0];
            }
        }

        public bool FileExists(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (string.IsNullOrWhiteSpace(path))
                throw new System.ArgumentException("Path cannot be empty", "path");
            if (!nativeFileSystem.IsPathValid(actualPath, true))
                throw new InvalidPathException(actualPath);

            try
            {
                return nativeFileSystem.FileExists(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to check if file {0} exists ({1})", path, e.Message);

                return false;
            }
        }

        public void DeleteFile(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (string.IsNullOrWhiteSpace(path))
                throw new System.ArgumentException("Path cannot be empty", "path");
            if (!nativeFileSystem.IsPathValid(actualPath, true))
                throw new InvalidPathException(actualPath);

            try
            {
                nativeFileSystem.DeleteFile(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to delete file {0} ({1})", path, e.Message);
            }
        }

        public FileInfo GetFileInfo(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (string.IsNullOrWhiteSpace(path))
                throw new System.ArgumentException("Path cannot be empty", "path");
            if (!nativeFileSystem.IsPathValid(actualPath, true))
                throw new InvalidPathException(actualPath);

            try
            {
                if (!nativeFileSystem.FileExists(path))
                {
                    throw new FileNotFoundException("File not found");
                }

                FileInfo info = nativeFileSystem.GetFileInfo(actualPath);

                info.ParentPath = info.ParentPath == fs_root ? string.Empty : info.ParentPath.Substring(fs_root.Length + 1);

                return info;
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to get file info for {0} ({1})", path, e.Message);

                throw;
            }
        }

        public File OpenFile(string path, FileMode mode, FileAccess access)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            if (string.IsNullOrWhiteSpace(path))
                throw new System.ArgumentException("Path cannot be empty", "path");
            if (!nativeFileSystem.IsPathValid(actualPath, true))
                throw new InvalidPathException(actualPath);
            if (mode == FileMode.Append && access != FileAccess.Write)
                throw new System.ArgumentException("FileMode.Append can only have FileAccess.Read", "access");
            else if (mode == FileMode.Create && !access.HasFlag(FileAccess.Write))
                throw new System.ArgumentException("FileMode.Create requires FileAccess.Write", "access");
            else if (mode == FileMode.OpenOrCreate && !access.HasFlag(FileAccess.Write))
                throw new System.ArgumentException("FileMode.Create requires FileAccess.Write", "access");

            try
            {
                File file = nativeFileSystem.OpenFile(actualPath, mode, access);

                file.ParentPath = file.ParentPath == fs_root ? string.Empty : file.ParentPath.Substring(fs_root.Length + 1);

                return file;
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Failed to open file {0} ({1})", path, e.Message);

                throw;
            }
        }
    }
}

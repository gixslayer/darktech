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

            try
            {
                return nativeFileSystem.DirectoryExists(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", e.Message);

                return false;
            }
        }

        public void CreateDirectory(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            try
            {
                nativeFileSystem.CreateDirectory(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", e.Message);
            }
        }

        public void DeleteDirectory(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            try
            {
                nativeFileSystem.DeleteDirectory(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", e.Message);
            }
        }

        public string[] GetDirectories(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

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
                Engine.Log.WriteLine("error/system/filesystem", e.Message);

                return new string[0];
            }
        }

        public string[] GetFiles(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

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
                Engine.Log.WriteLine("error/system/filesystem", e.Message);

                return new string[0];
            }
        }

        public bool FileExists(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            try
            {
                return nativeFileSystem.FileExists(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", e.Message);

                return false;
            }
        }

        public void DeleteFile(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            try
            {
                nativeFileSystem.DeleteFile(actualPath);
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", e.Message);
            }
        }

        public FileInfo GetFileInfo(string path)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            try
            {
                if (!nativeFileSystem.FileExists(path))
                {
                    throw new FileSystemException("Could not find file {0}", path);
                }

                FileInfo info = nativeFileSystem.GetFileInfo(actualPath);

                info.ParentPath = info.ParentPath == fs_root ? string.Empty : info.ParentPath.Substring(fs_root.Length + 1);

                return info;
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", e.Message);

                throw e;
            }
        }

        public File OpenFile(string path, FileMode mode, FileAccess access)
        {
            string actualPath = nativeFileSystem.CombinePaths(fs_root, path);

            // Verify file mode/access flags.
            if (mode == FileMode.Append && access != FileAccess.Write)
            {
                Engine.Log.WriteLine("error/system/filesystem", "Invalid access flags on file {0} (FileMode.Append can only have FileAccess.Read", path);

                throw new FileSystemException("Invalid access flags on file {0}", path);
            }
            else if (mode == FileMode.Create && !access.HasFlag(FileAccess.Write))
            {

            }
            else if (mode == FileMode.OpenOrCreate && !access.HasFlag(FileAccess.Write))
            {

            }

            try
            {
                File file = nativeFileSystem.OpenFile(actualPath, mode, access);

                file.ParentPath = file.ParentPath == fs_root ? string.Empty : file.ParentPath.Substring(fs_root.Length + 1);

                return file;
            }
            catch (FileSystemException e)
            {
                Engine.Log.WriteLine("error/system/filesystem", e.Message);

                throw e;
            }
        }
    }
}

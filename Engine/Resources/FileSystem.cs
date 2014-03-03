using StringBuilder = System.Text.StringBuilder;

namespace DarkTech.Engine.Resources
{
    public abstract class FileSystem
    {
        public const char DIRECTORY_SEPARATOR = '\\';

        public abstract bool DirectoryExists(string path);
        public abstract void CreateDirectory(string path);
        public abstract void DeleteDirectory(string path);
        public abstract string[] GetFiles(string path);
        public abstract string[] GetDirectories(string path);

        public abstract bool FileExists(string path);
        public abstract void DeleteFile(string path);
        public abstract FileInfo GetFileInfo(string path);
        public abstract File OpenFile(string path, FileMode mode, FileAccess access);
        public abstract void CloseFile(File file);

        public string CombinePath(params string[] paths)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string path;

            for (int i = 0; i < paths.Length; i++)
            {
                path = paths[i];

                // Strip leading path separators.
                path = path.TrimStart(DIRECTORY_SEPARATOR);

                // Ignore empty paths.
                if (path.Equals(string.Empty))
                {
                    continue;
                }

                // Strip tailing path separators.
                path = path.TrimEnd(DIRECTORY_SEPARATOR);

                // Append the path and a directory separator to the return value.
                stringBuilder.Append(path);
                stringBuilder.Append(DIRECTORY_SEPARATOR);
            }

            int length = stringBuilder.Length == 0 ? 0 : stringBuilder.Length - 1;

            return stringBuilder.ToString(0, length);
        }
    }
}

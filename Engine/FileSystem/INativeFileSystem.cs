namespace DarkTech.Engine.FileSystem
{
    internal interface INativeFileSystem
    {
        bool DirectoryExists(string path);
        void CreateDirectory(string path);
        void DeleteDirectory(string path);
        string[] GetDirectories(string path);
        string[] GetFiles(string path);
        bool FileExists(string path);
        void DeleteFile(string path);
        FileInfo GetFileInfo(string path);
        File OpenFile(string path, FileMode mode, FileAccess access);

        string CombinePaths(params string[] paths);
        bool IsPathValid(string path, bool fileName);
    }
}

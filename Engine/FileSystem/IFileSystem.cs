using StringBuilder = System.Text.StringBuilder;

namespace DarkTech.Engine.FileSystem
{
    public interface IFileSystem
    {
        bool DirectoryExists(string path);
        void CreateDirectory(string path);
        void DeleteDirectory(string path);
        string[] GetFiles(string path);
        string[] GetDirectories(string path);

        bool FileExists(string path);
        void DeleteFile(string path);
        FileInfo GetFileInfo(string path);
        bool OpenFile(string path, FileMode mode, FileAccess access, out File file);   
    }
}

﻿namespace DarkTech.Engine.FileSystem
{
    public interface IFileSystem
    {
        bool DirectoryExists(string path);
        void CreateDirectory(string path);
        void DeleteDirectory(string path);
        bool FileExists(string path);
        void DeleteFile(string path);
        string[] GetDirectories(string path);
        string[] GetFiles(string path);
        FileInfo GetFileInfo(string path);
        File OpenFile(string path, FileMode mode, FileAccess access);
    }
}

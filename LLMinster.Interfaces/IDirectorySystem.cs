using System.IO;

namespace LLMinster.Interfaces;

public interface IDirectorySystem
{
    string[] GetFiles(string directoryPath, string fileSearchPattern);
    DirectoryInfo CreateDirectory(string directoryPath);

    string[] GetDirectories(string directoryPath);
    void Delete(string directoryPath, bool recursive = false);
    bool Exists(string directoryPath);
}
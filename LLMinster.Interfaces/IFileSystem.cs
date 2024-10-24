using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LLMinster.Interfaces;

public interface IFileSystem
{
    string ReadAllText(string filePath);
    byte[] ReadAllBytes(string filePath);
    Task<byte[]> ReadAllBytesAsync(string filePath, CancellationToken token = default);

    DateTime GetCreationTimeUtc(string filePath);
    DateTime GetLastWriteTimeUtc(string filePath);
    bool Exists(string filePath);
    Task<string> ReadAllTextAsync(string filePath, CancellationToken token = default);
    Task WriteAllTextAsync(string filePath, string content, CancellationToken token = default);

    string[] ReadAllLines(string filePath);

    Task<string[]> ReadAllLinesAsync(string filePath, CancellationToken token = default);

    void WriteAllLines(string filePath, IEnumerable<string> content);
    Task WriteAllLinesAsync(string filePath, IEnumerable<string> content, CancellationToken token = default);

    void Delete(string filePath);
}
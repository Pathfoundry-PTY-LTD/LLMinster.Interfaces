using System.Threading.Tasks;

namespace LLMinster.Interfaces;

public interface ILLMClient
{   
    Task<string> GenerateContentAsync(string prompt, GenerationOptions options);
}
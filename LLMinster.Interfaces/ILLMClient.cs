using System.Threading;
using System.Threading.Tasks;

namespace LLMinster.Interfaces;

public interface ILLMClient
{
    Task<string> GenerateContentAsync(GenerationOptions options, CancellationToken cancellationToken = default);
}
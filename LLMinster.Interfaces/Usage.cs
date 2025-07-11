namespace LLMinster.Interfaces;

public record Usage(
    int PromptTokens,
    int CompletionTokens,
    int TotalTokens
);
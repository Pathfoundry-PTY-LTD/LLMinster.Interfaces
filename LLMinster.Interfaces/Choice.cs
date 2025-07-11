namespace LLMinster.Interfaces;

public record Choice(
    int Index,
    Message Message,
    string? FinishReason
);
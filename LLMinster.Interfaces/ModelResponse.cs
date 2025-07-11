using System.Collections.Generic;

namespace LLMinster.Interfaces;

public record ModelResponse(
    string Id,
    List<Choice> Choices,
    Usage Usage,
    string Model
);
using System.Collections.Generic;

namespace LLMinster.Interfaces;

public record Message(
    string Role,
    List<ContentPart> Content
);
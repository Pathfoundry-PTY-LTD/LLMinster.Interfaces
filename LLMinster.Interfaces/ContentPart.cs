namespace LLMinster.Interfaces;

public record ContentPart(
    string Type, // "text" or "image_url"
    string? Text = null,
    ImageUrl? ImageUrl = null
);
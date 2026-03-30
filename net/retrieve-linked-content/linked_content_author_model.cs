using Kontent.Ai.Delivery.ContentItems.RichText;

// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
public record Author
{
    public string? Name { get; init; }
    public RichTextContent? Bio { get; init; }
}

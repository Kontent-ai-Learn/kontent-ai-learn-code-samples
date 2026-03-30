using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.ContentItems.RichText;

// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
public record SimpleArticle
{
    public string? Title { get; init; }
    public RichTextContent? Body { get; init; }
    public IEnumerable<IEmbeddedContent>? Author { get; init; }
}

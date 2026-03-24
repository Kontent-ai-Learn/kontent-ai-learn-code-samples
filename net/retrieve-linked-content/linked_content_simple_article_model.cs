using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.ContentItems.RichText;

namespace KontentAiSamples.RetrieveLinkedContent;

public record SimpleArticle
{
    public string? Title { get; init; }

    public RichTextContent? Body { get; init; }

    public IEnumerable<IEmbeddedContent>? Author { get; init; }
}

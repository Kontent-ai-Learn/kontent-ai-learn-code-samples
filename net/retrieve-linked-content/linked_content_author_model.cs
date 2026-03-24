using Kontent.Ai.Delivery.ContentItems.RichText;

namespace KontentAiSamples.RetrieveLinkedContent;

public record Author
{
    public string? Name { get; init; }

    public RichTextContent? Bio { get; init; }
}

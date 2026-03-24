using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiSamples.StructureInRte;

public static class CustomContentLinkResolverSample
{
    public static ValueTask<string> ResolveLinkUrlAsync(IContentItemLink link)
    {
        if (link.Metadata?.ContentTypeCodename == "article")
        {
            return ValueTask.FromResult($"/articles/{link.Metadata?.UrlSlug}");
        }

        return ValueTask.FromResult("/404");
    }
}

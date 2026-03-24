using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;

namespace KontentAiSamples.StructureInRte;

public static class StructureInRteRegisterLinkResolverSample
{
    public static IHtmlResolver CreateResolver()
    {
        return new HtmlResolverBuilder()
            .WithContentItemLinkResolver("article", (link, _) =>
                ValueTask.FromResult($"/articles/{link.Metadata?.UrlSlug}"))
            .WithContentItemLinkResolver((_, _) =>
                ValueTask.FromResult("/404"))
            .Build();
    }
}

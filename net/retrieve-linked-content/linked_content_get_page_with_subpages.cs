using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiSamples.RetrieveLinkedContent;

public record Page
{
    public string? Title { get; init; }

    public IEnumerable<IEmbeddedContent>? Subpages { get; init; }
}

public static class LinkedContentGetPageWithSubpagesSample
{
    public static async Task<IContentItem<Page>?> GetPageWithSubpagesAsync(
        IDeliveryClient client,
        string codename = "insurance_listing")
    {
        var result = await client.GetItem<Page>(codename)
            .Depth(1)
            .ExecuteAsync();

        return result.IsSuccess ? result.Value : null;
    }
}

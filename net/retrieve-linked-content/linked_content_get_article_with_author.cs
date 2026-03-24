using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiSamples.RetrieveLinkedContent;

public static class LinkedContentGetArticleWithAuthorSample
{
    public static async Task<IContentItem<SimpleArticle>?> GetArticleWithAuthorAsync(
        IDeliveryClient client,
        string codename = "the_origin_of_coffee")
    {
        var result = await client.GetItem<SimpleArticle>(codename)
            .Depth(1)
            .ExecuteAsync();

        return result.IsSuccess ? result.Value : null;
    }
}

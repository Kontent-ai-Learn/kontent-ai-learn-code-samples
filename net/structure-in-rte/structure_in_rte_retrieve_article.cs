using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiSamples.StructureInRte;

public static class StructureInRteRetrieveArticleSample
{
    public static async Task<string?> GetArticleBodyAsHtmlAsync(
        IDeliveryClient client,
        string codename = "my_article")
    {
        var result = await client.GetItem<KontentAiSamples.RetrieveLinkedContent.SimpleArticle>(codename)
            .ExecuteAsync();

        if (!result.IsSuccess || result.Value.Elements.Body is null)
        {
            return null;
        }

        return await result.Value.Elements.Body.ToHtmlAsync();
    }
}

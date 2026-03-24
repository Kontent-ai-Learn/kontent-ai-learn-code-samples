using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;

namespace KontentAiSamples.StructureInRte;

public static class StructureInRteRegisterResolverSample
{
    public static IHtmlResolver CreateResolver()
    {
        return new HtmlResolverBuilder()
            .WithContentResolver<Tweet>(tweet =>
                $"<blockquote class=\"twitter-tweet\"><a href=\"{tweet.Elements.TweetLink}\"></a></blockquote>")
            .Build();
    }
}

namespace KontentAiSamples.StructureInRte;

public record Tweet
{
    public string? Theme { get; init; }

    public string? TweetLink { get; init; }
}

public static class TweetResolverSample
{
    public static string Resolve(Tweet data) =>
        $"<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"{data.Theme}\"><a href=\"{data.TweetLink}\"></a></blockquote>";
}

using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;

// Build an HTML resolver for embedded content items and content item links
var resolver = new HtmlResolverBuilder()
    // Render embedded Tweet components
    .WithContentResolver<Tweet>(tweet =>
        $"<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"{tweet.Elements.Theme}\"><a href=\"{tweet.Elements.TweetLink}\"></a></blockquote>")
    // Render embedded YouTube video components
    .WithContentResolver<Video>(video =>
        $"<iframe src=\"https://youtube.com/embed/{video.Elements.VideoId}\"></iframe>")
    .Build();

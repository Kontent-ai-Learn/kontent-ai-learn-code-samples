using System.Text.Encodings.Web;
using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;
using KontentAiModels;

// Build an HTML resolver for embedded content items
// The returned markup is inserted as is, so encode element values with HtmlEncoder
var resolver = new HtmlResolverBuilder()
    // Render embedded Tweet components
    .WithContentResolver<Tweet>(tweet =>
        $"<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"{tweet.Elements.Theme?.FirstOrDefault()?.Codename}\"><a href=\"{HtmlEncoder.Default.Encode(tweet.Elements.TweetLink ?? "")}\"></a></blockquote>")
    // Render embedded YouTube video components
    .WithContentResolver<Video>(video =>
        $"<iframe src=\"https://youtube.com/embed/{HtmlEncoder.Default.Encode(video.Elements.VideoId ?? "")}\"></iframe>")
    .Build();

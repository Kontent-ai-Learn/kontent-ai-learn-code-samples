using System.Text.Encodings.Web;
using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;
using KontentAiModels;

// The returned markup is inserted as is, so encode element values with HtmlEncoder
var resolver = new HtmlResolverBuilder()
    .WithContentResolver<YoutubeVideo>(video =>
    {
        var videoId = HtmlEncoder.Default.Encode(video.Elements.VideoId ?? "");
        var title = HtmlEncoder.Default.Encode(video.Elements.Title ?? "YouTube video");

        return $"""
            <iframe src="https://www.youtube.com/embed/{videoId}" title="{title}" width="560" height="315"
                    referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
            """;
    })
    .Build();

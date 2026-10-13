using System.Text.Encodings.Web;
using Kontent.Ai.Delivery.Abstractions;

BlockResolver<IContentItemLink> linkResolver = async (link, resolveChildren) =>
{
    // The link text with its formatting, already rendered to HTML, so don't encode it
    var text = await resolveChildren(link.Children);

    // Metadata is null when the linked item isn't available, such as when it's deleted or unpublished
    var metadata = link.Metadata;
    var slug = metadata is { UrlSlug.Length: > 0 } ? metadata.UrlSlug : metadata?.Codename;

    var url = metadata?.ContentTypeCodename switch
    {
        "article" => $"/articles/{slug}",
        "product" => $"/products/{slug}",
        _ => null
    };

    return url is null ? text : $"<a href=\"{HtmlEncoder.Default.Encode(url)}\">{text}</a>";
};

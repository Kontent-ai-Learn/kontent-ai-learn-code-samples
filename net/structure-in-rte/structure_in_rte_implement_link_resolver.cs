public class CustomContentLinkUrlResolver : IContentLinkUrlResolver
{
    public Task<string> ResolveLinkUrlAsync(IContentLink link)
    {
        // Resolves URLs to content items based on the Article content type
        if (link.ContentTypeCodename == "article")
        {
            return Task.FromResult($"/articles/{link.UrlSlug}");
        }

        // TODO: Add the rest of the resolver logic
    }

    public Task<string> ResolveBrokenLinkUrlAsync()
    {
        // Resolves URLs to unavailable content items
        return Task.FromResult("/404");
    }
}

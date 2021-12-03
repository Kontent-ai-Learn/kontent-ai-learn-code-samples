// DocSection: building_first_net_app_resolving_urls
public Task<string> ResolveLinkUrlAsync(IContentLink link)
{
    // Resolves links pointing to Article content items
    if (link.ContentTypeCodename.Equals(Article.Codename))
    {
        return Task.FromResult($"/articles/{link.UrlSlug}");
    }

    // Add the rest of the resolver logic
}

public Task<string> ResolveBrokenLinkUrlAsync()
{
    // Resolves URLs to unavailable content items
    return Task.FromResult("/Error/404");
}
// EndDocSection
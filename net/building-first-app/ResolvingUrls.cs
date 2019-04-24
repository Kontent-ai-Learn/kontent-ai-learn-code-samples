// DocSection: building_first_net_app_resolving_urls
public string ResolveLinkUrl(ContentLink link)
{
    // Resolves links pointing to Article content items
    if (link.ContentTypeCodename.Equals(Article.Codename))
    {
        return $"/articles/{link.UrlSlug}";
    }

    // Add the rest of the resolver logic
}

public string ResolveBrokenLinkUrl()
{
    // Resolves URLs to unavailable content items
    return "/Error/404";
}
// EndDocSection
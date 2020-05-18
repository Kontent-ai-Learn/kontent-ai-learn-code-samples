// DocSection: structure_in_rte_implement_link_resolver
public class CustomContentLinkUrlResolver : IContentLinkUrlResolver
{
    public string ResolveLinkUrl(ContentLink link)
    {
        // Resolves URLs to content items based on the Article content type
        if (link.ContentTypeCodename == "article")
        {
            return $"/articles/{link.UrlSlug}";
        }

        // TODO: Add the rest of the resolver logic
    }

    public string ResolveBrokenLinkUrl()
    {
        // Resolves URLs to unavailable content items
        return "/404";
    }
}
// EndDocSection
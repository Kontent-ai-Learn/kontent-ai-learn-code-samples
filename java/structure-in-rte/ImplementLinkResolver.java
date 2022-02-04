// DocSection: structure_in_rte_implement_link_resolver
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
public class CustomContentLinkUrlResolver implements ContentLinkUrlResolver {
    
    @Override
    String resolveLinkUrl(Link link) {
        // Resolves URLs to content items based on the Article content type
        if ("my_article".equals(link.getCodename())) {
            return String.format("/articles/%s", link.getUrlSlug());
        }
    }
}

public class CustomBrokenContentLinkUrlResolver implements BrokenLinkUrlResolver {

    @Override
    String resolveBrokenLinkUrl() {
        // Resolves URLs to unavailable content items
        return "/404";
    }
}
// EndDocSection
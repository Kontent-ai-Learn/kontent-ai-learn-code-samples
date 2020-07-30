<?php
// DocSection: structure_in_rte_implement_link_resolver
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
class CustomContentLinkUrlResolver implements ContentLinkUrlResolverInterface
{
    public function resolveLinkUrl($link)
    {
        // Resolves URLs to content items based on the Article content type
        if ($link->contentTypeCodeName == "my_article") {
            return "/articles/". $link->urlSlug;
        }

        // TODO: Add the rest of the resolver logic
    }

    public function resolveBrokenLinkUrl()
    {
        // Resolves URLs to unavailable content items
        return "/404";
    }    
}
// EndDocSection
?>
<?php
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
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
?>
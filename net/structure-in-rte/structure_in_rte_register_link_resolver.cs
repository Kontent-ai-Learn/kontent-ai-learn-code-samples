using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;

// Build an HTML resolver with the content item link resolver from the previous step
var resolver = new HtmlResolverBuilder()
    .WithContentItemLinkResolver(linkResolver)
    .Build();

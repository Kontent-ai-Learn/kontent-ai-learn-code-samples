using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;

var resolver = new HtmlResolverBuilder()
    .WithContentItemLinkResolver(linkResolver)
    .Build();

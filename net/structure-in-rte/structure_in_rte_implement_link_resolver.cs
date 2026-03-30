using Kontent.Ai.Delivery.ContentItems.RichText.Resolution;

// Define URL patterns for resolving content item links by content type
// Available placeholders: {codename}, {type}, {urlslug}, {id}
var linkResolver = DefaultResolvers.UrlPatternResolver(new Dictionary<string, string>
{
    ["article"] = "/articles/{urlslug}"
});

// For other means of resolving links, see SDK docs:
// https://github.com/kontent-ai/delivery-sdk-net/blob/master/docs/rich-text-customization.md#content-item-link-resolvers

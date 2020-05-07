// DocSection: structure_in_rte_implement_link_resolver
// This is a global resolver for all links to articles. You can also define a resolver for a given query: https://github.com/Kentico/kontent-delivery-sdk-js/blob/master/DOCS.md#resolving-url-slugs-on-query-level

class Article extends ContentItem {
    constructor() {
        super({
            urlSlugResolver: (link, context) => {
                return { url: `/articles/${url_slug}` };
            }
        })
    }
}

// EndDocSection
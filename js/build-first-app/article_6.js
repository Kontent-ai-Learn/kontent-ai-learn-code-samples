// DocSection: build_first_js_app_article_6_queryconfig
deliveryClient
  .items()
  .type('article')
  .equalsFilter('elements.url_pattern', articleSlug)
  .queryConfig({
    urlSlugResolver: (link, context) => {
      return resolveUrl(link);
    },
    richTextResolver: (item, context) => {
      return resolveLinkedItems(item);
    }
  })
  .toPromise()
  // Continue as above
// EndDocSection
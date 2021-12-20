// DocSection: build_first_js_app_article_3_queryconfig
deliveryClient
  .items()
  .type('article')
  .equalsFilter('elements.url_pattern', articleSlug)
  .queryConfig({
    urlSlugResolver: (link, context) => {
      return resolveUrl(link);
    },
  })
  .toPromise()
  // Continue as above
// EndDocSection
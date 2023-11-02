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

// Gets items in default language with the URL slug element equal to 'sample-url-slug'
const itemsByUrlSlug = await deliveryClient.items()
  .equalsFilter('elements.url_slug', 'sample-url-slug')
  .toPromise();
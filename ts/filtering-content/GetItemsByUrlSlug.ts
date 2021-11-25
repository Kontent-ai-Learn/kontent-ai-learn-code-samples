// DocSection: filtering_get_items_by_url_slug
// Gets items whose URL slug equals to sample-url-slug
const response = await deliveryClient.items()
  .equalsFilter('elements.url_slug', 'sample-url-slug')
  .toPromise();
// EndDocSection
// DocSection: filtering_get_items_by_url_slug
// Gets items whose URL slug equals to sample-url-slug
deliveryClient.items<ContentItem>()
  .equalsFilter('elements.url_slug', 'sample-url-slug')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
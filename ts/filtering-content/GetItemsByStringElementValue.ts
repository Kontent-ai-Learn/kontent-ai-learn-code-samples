// DocSection: filtering_get_items_by_string
// Gets items whose Title element value equals to 'Hello World'
deliveryClient.items<ContentItem>()
  .equalsFilter('elements.title', 'Hello World')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
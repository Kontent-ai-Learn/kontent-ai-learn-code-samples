// DocSection: filtering_get_items_by_string
// Gets items whose Title element value equals to "Hello World"
const response = await deliveryClient.items()
  .equalsFilter('elements.title', 'Hello World')
  .toPromise();
// EndDocSection
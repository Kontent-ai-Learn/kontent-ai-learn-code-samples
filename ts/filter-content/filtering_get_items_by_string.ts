// Gets items whose Title element value equals to 'Hello World'
const itemsByTitle = await deliveryClient.items()
  .equalsFilter('elements.title', 'Hello World')
  .toPromise();
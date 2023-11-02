// Gets items attributed to Jane.
const response = await deliveryClient.items()
  .containsFilter('elements.author', ['jane_doe'])
  .toPromise();

// Gets items attributed to at least Jane, John, or both.
const response = await deliveryClient.items()  
  .anyFilter('elements.author', ['jane_doe', 'john_wick'])
  .toPromise();

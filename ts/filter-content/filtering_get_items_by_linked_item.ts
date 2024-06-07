// # Gets a list of items where the 'my_page' item is used in the 'navigation' element.
const response = await deliveryClient.items()
  .containsFilter('elements.navigation', ['my_page'])
  .toPromise();

// Gets items linked to at least Jane, John, or both.
const response = await deliveryClient.items()  
  .anyFilter('elements.author', ['jane_doe', 'john_wick'])
  .toPromise();

  // Gets pages linking travel insurance as their subpage.
const response = await deliveryClient.items()
.containsFilter('elements.subpages', ['travel_insurance'])
.toPromise();

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
const response = await deliveryClient.items()
.anyFilter('elements.subpages', ['travel_insurance', 'car_insurance'])
.toPromise();
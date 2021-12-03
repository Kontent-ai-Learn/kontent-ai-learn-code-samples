// DocSection: filtering_get_subpages
// Gets pages linking travel insurance as their subpage.
const response = await deliveryClient.items()
  .containsFilter('elements.subpages', ['travel_insurance'])
  .toPromise();

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
const response = await deliveryClient.items()
  .anyFilter('elements.subpages', ['travel_insurance', 'car_insurance'])
  .toPromise();
// EndDocSection
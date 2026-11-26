// @kontent-ai/delivery-sdk v16
// Gets a list of items where the 'my_page' item is used in the 'navigation' element
const itemsLinkedToPage = await deliveryClient.items()
  .containsFilter('elements.navigation', ['my_page'])
  .toPromise();

// Gets items linked to at least Jane, John, or both
const itemsWithSpecificAuthor = await deliveryClient.items()  
  .anyFilter('elements.author', ['jane_doe', 'john_wick'])
  .toPromise();

  // Gets pages linking travel insurance as their subpage
const itemsLinkedToSubpage = await deliveryClient.items()
.containsFilter('elements.subpages', ['travel_insurance'])
.toPromise();

// Gets pages linking at least travel insurance, car insurance, or both as their subpage
const itemsLinkedToSubpages = await deliveryClient.items()
.anyFilter('elements.subpages', ['travel_insurance', 'car_insurance'])
.toPromise();

// @kontent-ai/delivery-sdk v17
// Gets a list of items where the 'my_page' item is used in the 'navigation' element
const itemsLinkedToPage = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.navigation', operator: 'contains', value: 'my_page' }]
})
  .fetchPage();

// Gets items linked to at least Jane, John, or both
const itemsWithSpecificAuthor = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.author', operator: 'any', value: ['jane_doe', 'john_wick'] }]
})
  .fetchPage();

// Gets pages linking travel insurance as their subpage
const itemsLinkedToSubpage = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.subpages', operator: 'contains', value: 'travel_insurance' }]
})
  .fetchPage();

// Gets pages linking at least travel insurance, car insurance, or both as their subpage
const itemsLinkedToSubpages = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.subpages', operator: 'any', value: ['travel_insurance', 'car_insurance'] }]
})
  .fetchPage();

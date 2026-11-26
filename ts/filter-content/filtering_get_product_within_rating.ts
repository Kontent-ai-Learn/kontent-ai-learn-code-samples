// @kontent-ai/delivery-sdk v16
// Gets items whose rating is at least 6.5 and at most 9
const itemsByNumberRange = await deliveryClient.items()
  .rangeFilter('elements.product_rating', '6.5', '9')
  .toPromise();

// @kontent-ai/delivery-sdk v17
// Gets items whose rating is at least 6.5 and at most 9
const itemsByNumberRange = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.product_rating', operator: 'range', value: [6.5, 9] }]
})
  .fetchPage();

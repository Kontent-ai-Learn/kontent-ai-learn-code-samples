// @kontent-ai/delivery-sdk v16
// Gets items whose Title element value equals to 'Hello World'
const itemsByTitle = await deliveryClient.items()
  .equalsFilter('elements.title', 'Hello World')
  .toPromise();

// @kontent-ai/delivery-sdk v17
// Gets items whose Title element value equals to 'Hello World'
const itemsByTitle = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.title', operator: 'eq', value: 'Hello World' }]
})
  .fetchPage();

// @kontent-ai/delivery-sdk v16
// Gets an item by its internal ID
const itemById = await deliveryClient.items()
  .equalsFilter('system.id', '2f7288a1-cfc8-47be-9bf1-b1d312f7da18')
  .toPromise();

// @kontent-ai/delivery-sdk v17
// Gets an item by its internal ID
const itemById = await deliveryClient.listContentItems({
  filters: [{ property: 'system.id', operator: 'eq', value: '2f7288a1-cfc8-47be-9bf1-b1d312f7da18' }]
})
  .fetchPage();

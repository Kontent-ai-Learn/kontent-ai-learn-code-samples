// @kontent-ai/delivery-sdk v16
// Gets items based on the type Product
const itemsByType = await deliveryClient.items()
  .equalsFilter('system.type', 'product') // Same as using .type('product')
  .toPromise();

// @kontent-ai/delivery-sdk v17
// Gets items based on the type Product
const itemsByType = await deliveryClient.listContentItems({
  filters: [{ property: 'system.type', operator: 'eq', value: 'product' }] // Same as using ofContentTypes: ['product']
})
  .fetchPage();

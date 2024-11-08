// Gets items based on the type Product
const itemsByType = await deliveryClient.items()
  .equalsFilter('system.type', 'product') // Same as using .type('product')
  .toPromise();
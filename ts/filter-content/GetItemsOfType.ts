// DocSection: filtering_get_items_of_type
// Gets items based on the type Product
const response = await deliveryClient.items()
  .equalsFilter('system.type', 'product') // Same as using .type('product')
  .toPromise();
// EndDocSection
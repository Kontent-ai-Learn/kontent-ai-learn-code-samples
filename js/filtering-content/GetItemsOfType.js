// DocSection: filtering_get_items_of_type
deliveryClient.items()
  // Gets items based on the type Product
  .equalsFilter('system.type', 'product')
  // Does the same as using .type('product')
// EndDocSection
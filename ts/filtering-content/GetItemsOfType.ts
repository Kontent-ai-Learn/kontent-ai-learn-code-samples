// DocSection: filtering_get_items_of_type
// Gets items based on the type Product
deliveryClient.items<ContentItem>()
  .equalsFilter('system.type', 'product') // Same as using .type('product')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
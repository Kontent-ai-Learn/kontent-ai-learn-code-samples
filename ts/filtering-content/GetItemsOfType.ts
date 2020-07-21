// DocSection: filtering_get_items_of_type
deliveryClient.items<ContentItem>()
  // Gets items based on the type Product
  .equalsFilter("system.type", "product")
  // Same as using .type('product')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
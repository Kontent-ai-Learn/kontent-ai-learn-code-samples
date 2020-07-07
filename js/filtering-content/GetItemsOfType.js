// DocSection: filtering_get_items_of_type
deliveryClient.items()
  // Gets items of content type Product
  .equalsFilter("system.type", "product")
// EndDocSection

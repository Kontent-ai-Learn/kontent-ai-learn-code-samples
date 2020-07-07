// DocSection: filtering_get_items_of_type
List<object> items = deliveryService.<Article>items()
  // Gets items of content type Product
  .equalsFilter("system.type", "product")
// EndDocSection

// DocSection: filtering_get_items_of_type
// Gets items of content type Product
List<Product> items = deliveryService.<Product>items()
    .equalsFilter("system.type", "product")
    .get()
    .getItems();
// EndDocSection
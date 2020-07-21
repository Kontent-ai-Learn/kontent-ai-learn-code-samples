// DocSection: filtering_get_items_of_type
List<Product> items = deliveryService.<Product>items()
    // Gets items of content type Product
    .equalsFilter("system.type", "product")
    .get()
    .getItems();
// EndDocSection

// DocSection: filtering_get_items_of_types
List<ContentItem> items = deliveryService.<ContentItem>items()
    // Gets items based on the types Article, Product, and News
    .inFilter("system.type", Arrays.asList("article", "product", "news"))
    .get()
    .getItems();
// EndDocSection

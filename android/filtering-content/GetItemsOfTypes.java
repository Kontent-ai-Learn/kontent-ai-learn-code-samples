// DocSection: filtering_get_items_of_types
// Gets items based on the types Article, Product, and News
List<ContentItem> items = deliveryService.<ContentItem>items()
    .inFilter("system.type", Arrays.asList("article", "product", "news"))
    .get()
    .getItems();
// EndDocSection


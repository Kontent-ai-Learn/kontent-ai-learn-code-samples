// DocSection: filtering_get_items_by_codename_in
// Gets three items by their codenames. The codenames are unique per project.
List<ContentItem> items = deliveryService.<ContentItem>items()
    .inFilter("system.codename", Arrays.asList("delivery_api", "get_content", "hello_world"))
    .get()
    .getItems();
// EndDocSection
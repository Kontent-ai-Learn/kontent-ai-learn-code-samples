// DocSection: filtering_get_items_by_string_element_value
List<ContentItem> items = deliveryService.<ContentItem>items()
    // Gets items whose Title element value equals to "Hello World"
    .filterEquals("elements.title", "Hello World")
    .get()
    .getItems();
// EndDocSection 
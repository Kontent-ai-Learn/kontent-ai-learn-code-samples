// DocSection: filtering_get_items_by_string
// Gets items whose Title element value equals to "Hello World"
List<ContentItem> items = deliveryService.<ContentItem>items()
    .filterEquals("elements.title", "Hello World")
    .get()
    .getItems();
// EndDocSection

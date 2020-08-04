// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
List<ContentItem> items = deliveryService.<ContentItem>items()
    .containsFilter("elements.tags", Arrays.asList("kentico"))
    .get()
    .getItems();

// Gets items tagged with a list of specific tags
List<object> items = deliveryService.<object>items()
    .allFilter("elements.tags", Arrays.asList("kontent", "headless"))
    .get()
    .getItems();

// Gets items tagged with at least one of multiple tags
List<object> items = deliveryService.<object>items()
    .anyFilter("elements.tags", Arrays.asList("football", "soccer"))
    .get()
    .getItems();
// EndDocSection
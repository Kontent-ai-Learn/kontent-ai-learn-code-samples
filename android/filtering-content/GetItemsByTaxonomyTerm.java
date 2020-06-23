// DocSection: filtering_get_items_by_taxonomy_term
List<object> items = deliveryService.<object>items()
  // Get articles tagged with specific tag
  .containsFilter("elements.tags", Arrays.asList("kentico"))

List<object> items = deliveryService.<object>items()
  ///Get articles tagged with any of the below tags
  .anyFilter("elements.tags", Arrays.asList("sport", "soccer"))

List<object> items = deliveryService.<object>items()
  //Get articles tagged with all of the below tags
  .allFilter("elements.tags", Arrays.asList("mvc", "kontent", "headless"))
// EndDocSection

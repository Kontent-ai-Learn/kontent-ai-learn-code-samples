// DocSection: filtering_get_items_by_taxonomy_term
deliveryClient.items()
  // Get articles tagged with specific tag
  .containsFilter("elements.tags", ["kentico"])

deliveryClient.items()
  /// Gets articles tagged with any of the below tags
  .anyFilter("elements.tags", ["football"], ["soccer"])

deliveryClient.items()
  // Gets articles tagged with all of the below tags
  .allFilter("elements.tags", ["mvc"], ["kontent"], ["headless"])
// EndDocSection

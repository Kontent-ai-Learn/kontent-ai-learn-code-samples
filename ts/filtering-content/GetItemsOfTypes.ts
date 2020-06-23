// DocSection: filtering_get_items_of_types
deliveryClient.items<ContentItem>()
  // Gets items of following content types
  .inFilter("system.type", ["product"], ["article"], ["news"])
// EndDocSection

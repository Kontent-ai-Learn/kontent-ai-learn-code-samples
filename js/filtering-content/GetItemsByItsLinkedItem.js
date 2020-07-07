// DocSection: filtering_get_items_its_linked_item
deliveryClient.items()
  // Gets items whose linked item has codename as one of specified values
  .anyFilter(“elements.authors”, [“john_snow”], ["johnny_bravo"])

deliveryClient.items()
  // Gets items whose linked item has codename of certain value
  .containsFilter(“elements.authors”, [“joe_down”])
// EndDocSection

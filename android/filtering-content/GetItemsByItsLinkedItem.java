// DocSection: filtering_get_items_its_linked_item
List<object> items = deliveryService.<object>items()
  // Gets items whose linked item has codename as one of specified values
  .anyFilter(“elements.authors”, Arrays.asList(“john_snow”, "johnny_bravo"))

List<object> items = deliveryService.<object>items()
  // Gets items whose linked item has codename of certain value
  .containsFilter(“elements.authors”, Arrays.asList(“joe_down”))
// EndDocSection

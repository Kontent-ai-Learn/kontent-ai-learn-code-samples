// DocSection: filtering_get_items_by_array_element_value
List<object> items = deliveryService.<object>items()
  // Get items where multiple choice has a specific value
  .containsFilter("elements.multiple_choice", Arrays.asList("value"))

List<object> items = deliveryService.<object>items()
  // Get items where multiple choice has any of the below values
  .anyFilter("elements.multiple_choice", Arrays.asList("value1", "value2"))
// EndDocSection

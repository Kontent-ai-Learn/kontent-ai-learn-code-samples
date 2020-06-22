// DocSection: filtering_get_items_by_array_element_value
deliveryClient.items()
  // Get items where multiple choice has a specific value
  .containsFilter("elements.multiple_choice", ["value"])

deliveryClient.items()
  // Get items where multiple choice has any of the below values
  .anyFilter("elements.multiple_choice", ["value1"], ["value2"])
// EndDocSection

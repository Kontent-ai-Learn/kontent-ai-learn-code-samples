// DocSection: filtering_get_items_by_array_element_value
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Get items where multiple choice has a specific value
  .filterContains("elements.multiple_choice", ["value"])

DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Get items where multiple choice has any of the below values
  .filterAny("elements.multiple_choice", ["value1"], ["value2"])
// EndDocSection

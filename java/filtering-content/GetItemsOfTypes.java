// DocSection: filtering_get_items_of_types
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items of following content types
  .filterIn("system.type", ["product"], ["article"], ["news"])
// EndDocSection

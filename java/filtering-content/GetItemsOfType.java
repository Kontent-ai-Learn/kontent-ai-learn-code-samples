// DocSection: filtering_get_items_of_type
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items of content type Product
  .filterEquals("system.type", "product")
// EndDocSection

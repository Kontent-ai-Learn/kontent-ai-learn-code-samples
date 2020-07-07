// DocSection: filtering_get_item_by_id
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets item by its ID
  .filterEquals("system.id", "2f7288a1-cfc8-47be-9bf1-b1d312f7da18")
// EndDocSection

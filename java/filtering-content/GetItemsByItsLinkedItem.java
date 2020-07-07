// DocSection: filtering_get_items_its_linked_item
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose linked item has codename as one of specified values
  .filterAny(“elements.authors”, [“john_snow”], ["johnny_bravo"])

List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose linked item has codename of certain value
  .filterContains(“elements.authors”, [“joe_down”])
// EndDocSection

// DocSection: filtering_get_published_from_to
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  .filterGreaterThan("elements.publish_date", "2020-05-10")

List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  .filterGreaterThanOrEqual("elements.publish_date", "2020-05-10")
  
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  .filterLessThan("elements.publish_date", "2020-05-20")

List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  .filterLessThanOrEqual("elements.publish_date", "2020-05-20")
// EndDocSection

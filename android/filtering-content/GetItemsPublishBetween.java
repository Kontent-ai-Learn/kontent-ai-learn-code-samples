// DocSection: filtering_get_published_between
List<object> items = deliveryService.<object>items()
  // Gets items whose publish date is at least 2020-05-10, 00:00:00 but no greater than 2020-05-20, 00:00:00
  .rangeFilter("elements.publish_date", "2020-05-10", "2020-05-20")
// EndDocSection

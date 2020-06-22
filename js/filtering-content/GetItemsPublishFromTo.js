// DocSection: filtering_get_published_from_to
deliveryClient.items()
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  .greaterThanFilter("elements.publish_date", "2020-05-10")

deliveryClient.items()
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  .greaterThanOrEqualFilter("elements.publish_date", "2020-05-10")

deliveryClient.items()
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  .lessThanFilter("elements.publish_date", "2020-05-20")

deliveryClient.items()
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  .lessThanOrEqualFilter("elements.publish_date", "2020-05-20")
// EndDocSection

// DocSection: filtering_get_published_from_to
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  new GreaterThanFilter("elements.publish_date", "2020-05-10"),
  // Gets items whose publish date is at least 2020-05-10, 00:00:00
  new GreaterThanOrEqualFilter("elements.publish_date", "2020-05-10"),
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  new LessThanFilter("elements.publish_date", "2020-05-20"),
  // Gets items whose publish date is at most 2020-05-19, 23:59:00
  new LessThanOrEqualFilter("elements.publish_date", "2020-05-20")
);
// EndDocSection

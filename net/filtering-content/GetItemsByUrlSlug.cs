// DocSection: filtering_get_items_by_url_slug
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items whose URL Slug is as follows - this is same as filtering by text element value
  new EqualsFilter("elements.url_slug", "article-title")
);
// EndDocSection

// DocSection: filtering_get_items_of_types
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items of following content types
  new InFilter("system.type", "product", "article", "news")
);
// EndDocSection

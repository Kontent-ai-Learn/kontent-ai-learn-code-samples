// DocSection: filtering_get_items_of_type
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items of content type Product
  new EqualsFilter("system.type", "product")
);
// EndDocSection

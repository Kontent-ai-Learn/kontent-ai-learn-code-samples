// DocSection: filtering_get_item_by_id
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets item by its ID
  new EqualsFilter("system.id", "2f7288a1-cfc8-47be-9bf1-b1d312f7da18")
);
// EndDocSection

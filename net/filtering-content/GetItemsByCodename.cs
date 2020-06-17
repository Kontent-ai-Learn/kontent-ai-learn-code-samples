// DocSection: filtering_get_items_by_codename_in
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items whose codename is one of the following
  new InFilter("system.codename", "welcome_to_mvc", "top_10_websites", "kontent_best_practices")
);
// EndDocSection

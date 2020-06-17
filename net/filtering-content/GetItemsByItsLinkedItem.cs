// DocSection: filtering_get_items_its_linked_item
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items whose linked item has codename as one of specified values
  new AnyFilter(“elements.authors”, “john_snow”, "johnny_bravo")
);

DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items whose linked item has codename of certain value
  new ContainsFilter(“elements.authors”, “joe_down”)
);
// EndDocSection

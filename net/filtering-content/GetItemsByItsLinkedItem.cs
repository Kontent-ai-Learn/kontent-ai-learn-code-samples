// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane. Matched items may also contain other authors.
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  new ContainsFilter("elements.author", "jane_doe")
);

// Gets items attributed to at least Jane, John, or both. Matched items may also contain other authors.
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  new AnyFilter("elements.author", "jane_doe", "john_wick")
);
// EndDocSection
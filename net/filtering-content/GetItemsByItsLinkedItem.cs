// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new ContainsFilter("elements.author", "jane_doe")
);

// Gets items attributed to at least Jane, John, or both.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new AnyFilter("elements.author", "jane_doe", "john_wick")
);
// EndDocSection
// Gets an item by its internal ID
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new EqualsFilter("system.id", "2f7288a1-cfc8-47be-9bf1-b1d312f7da18")
);

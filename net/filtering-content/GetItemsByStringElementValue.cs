// DocSection: filtering_get_items_by_string
// Gets items whose Title element value equals to "Hello World" 
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new EqualsFilter("elements.title", "Hello World")
);
// EndDocSection
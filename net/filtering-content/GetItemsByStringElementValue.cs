// DocSection: filtering_get_items_by_string_element_value
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    // Gets items whose Title element value equals to "Hello World" 
    new EqualsFilter("elements.title", "Hello World")
);
// EndDocSection
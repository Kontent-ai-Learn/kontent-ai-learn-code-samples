// Gets items whose Title element value equals to "Hello World" 
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new EqualsFilter("elements.title", "Hello World")
);

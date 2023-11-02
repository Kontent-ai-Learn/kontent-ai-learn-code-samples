// Gets items based on the type Product
IDeliveryItemListingResponse<Product> response = await deliveryClient.GetItemsAsync<Product>(
    new EqualsFilter("system.type", "product")
);

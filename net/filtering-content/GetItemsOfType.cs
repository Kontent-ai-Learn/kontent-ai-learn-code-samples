// DocSection: filtering_get_items_of_type
// Gets items based on the type Product
DeliveryItemListingResponse<Product> response = await deliveryClient.GetItemsAsync<Product>(
    new EqualsFilter("system.type", "product")
);
// EndDocSection

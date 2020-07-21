// DocSection: filtering_get_items_of_type
DeliveryItemListingResponse<Product> response = await deliveryClient.GetItemsAsync<Product>(
  // Gets items based on the type Product
  new EqualsFilter("system.type", "product")
);
// EndDocSection

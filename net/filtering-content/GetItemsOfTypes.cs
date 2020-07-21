// DocSection: filtering_get_items_of_types
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  // Gets items based on the types Product, Article, and News
  new InFilter("system.type", "product", "article", "news")
);
// EndDocSection

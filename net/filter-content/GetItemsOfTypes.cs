// DocSection: filtering_get_items_of_types
// Gets items based on the types Product, Article, and News
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new InFilter("system.type", "product", "article", "news")
);
// EndDocSection

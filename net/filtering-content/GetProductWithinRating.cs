// DocSection: filtering_get_product_within_rating
// Gets items whose rating is at least 6.5 and at most 9
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new RangeFilter("elements.product_rating", "6.5", "9")
);
// EndDocSection
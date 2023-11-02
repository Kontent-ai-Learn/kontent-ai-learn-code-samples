// Gets items whose rating is at least 6.5 and at most 9
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new RangeFilter("elements.product_rating", "6.5", "9")
);

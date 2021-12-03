// DocSection: filtering_get_items_by_url_slug
// Gets items whose URL slug equals to sample-url-slug
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new EqualsFilter("elements.url_slug", "sample-url-slug")
);
// EndDocSection
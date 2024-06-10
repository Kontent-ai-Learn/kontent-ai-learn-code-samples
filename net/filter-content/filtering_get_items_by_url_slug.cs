// Gets items in default language with the URL slug element equal to 'sample-url-slug'
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new EqualsFilter("elements.url_slug", "sample-url-slug")
);

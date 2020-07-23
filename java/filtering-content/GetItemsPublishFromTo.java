// DocSection: filtering_get_items_by_datetime
// system.last_modified value is stored with ms precision such as 2020-07-20T09:18:17.4857463Z
// Date&Time element value is stored with minute precision such as 2020-04-29T00:00:00Z
List<NameValuePair> params1 = DeliveryParameterBuilder.params()
    // Gets items modified after April 9 2020, 9 am UTC+0
    .filterGreaterThan("system.last_modified", "2020-05-09T09:00:00.000000Z")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params1);

List<NameValuePair> params2 = DeliveryParameterBuilder.params()
    // Gets items released at or after April 9 2020, 7 am UTC+0
    .filterGreaterThanOrEqual("elements.release_date", "2020-05-09T07:00:00Z")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params2);

List<NameValuePair> params3 = DeliveryParameterBuilder.params()
    // Gets items modified before April 5 2020 UTC+0
    // Last match would be at 2020-05-04T23:59:59
    .filterLessThan("system.last_modified", "2020-05-05")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params3);

List<NameValuePair> params4 = DeliveryParameterBuilder.params()
    // Gets items released at or before April 5 2020 10:30 am UTC+0
    .filterLessThanOrEqual("elements.release_date", "2020-05-05T10:30:00Z")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params4);
// EndDocSection
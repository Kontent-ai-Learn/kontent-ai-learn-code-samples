// DocSection: filtering_get_items_by_range
// Note: Date & time element values are provided by users and stored with minute precision. The system.last_modified value reflects Last content change to an item and is stored with ms precision.
// Gets items modified between April 5, 2020 10:30 UTC and April 7, 2020, 7:00 UTC
List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterRange("system.last_modified", "2020-05-05T10:30:00", "2020-05-07T07:00:00")
    .build()

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params);
// EndDocSection 
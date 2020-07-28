// DocSection: filtering_get_items_by_codename_in
// Gets three items by their codenames. The codenames are unique per project.
List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterIn("system.codename", "delivery_api", "get_content", "hello_world")
    .build()

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params);
// EndDocSection
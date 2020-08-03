// DocSection: filtering_get_items_by_string
// Gets items whose Title element value equals to "Hello World"
List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("elements.title", "Hello World")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params);
// EndDocSection
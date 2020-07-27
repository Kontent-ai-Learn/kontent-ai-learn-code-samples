// DocSection: filtering_get_items_by_string_element_value
List<NameValuePair> params = DeliveryParameterBuilder.params()
    // Gets items whose Title element value equals to "Hello World" 
    .filterEquals("elements.title", "Hello World")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params);
// EndDocSection
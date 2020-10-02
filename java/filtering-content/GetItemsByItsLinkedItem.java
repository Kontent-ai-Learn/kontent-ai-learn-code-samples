// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane.
List<NameValuePair> params1 = DeliveryParameterBuilder.params()
    .filterContains("elements.author", "jane_doe")
    .build();

CompletionStage<ContentItemsListingResponse> listingResponse1 = deliveryClient.getItems(params1);

// Gets items attributed to at least Jane, John, or both.
List<NameValuePair> params2 = DeliveryParameterBuilder.params()
    .filterAny("elements.authors", "jane_doe", "john_wick")
    .build();

CompletionStage<ContentItemsListingResponse> listingResponse2 = deliveryClient.getItems(params2);
// EndDocSection
// DocSection: filtering_get_subpages
// Gets pages linking travel insurance as their subpage.
List<NameValuePair> params1 = DeliveryParameterBuilder.params()
    .filterContains("elements.subpages", "travel_insurance")
    .build();

CompletionStage<ContentItemsListingResponse> listingResponse1 = deliveryClient.getItems(params1);

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
List<NameValuePair> params2 = DeliveryParameterBuilder.params()
    .filterAny("elements.subpages", "travel_insurance", "car_insurance")
    .build();

CompletionStage<ContentItemsListingResponse> listingResponse2 = deliveryClient.getItems(params2);
// EndDocSection
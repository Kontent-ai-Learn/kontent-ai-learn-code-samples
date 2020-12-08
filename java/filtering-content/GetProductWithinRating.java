// DocSection: filtering_get_product_within_rating
// Gets items whose rating is at least 6.5 and at most 9
List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterRange("elements.product_rating", "7.5", "9")
    .build();

CompletionStage<ContentItemsListingResponse> listingResponse = client.getItems();
// EndDocSection
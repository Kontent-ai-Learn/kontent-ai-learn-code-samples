// DocSection: filtering_get_items_by_url_slug
// Gets items whose URL slug equals to sample-url-slug
List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("elements.url_slug", "sample-url-slug")
    .build()

CompletionStage<ContentItemsListingResponse> listingResponse = deliveryClient.getItems(params);
// EndDocSection
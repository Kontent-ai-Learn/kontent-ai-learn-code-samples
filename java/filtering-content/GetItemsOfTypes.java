// DocSection: filtering_get_items_of_types
// Gets items based on the types Product, Article, and News
List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterIn("system.type", "product", "article", "news")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params);
// EndDocSection
// DocSection: filtering_get_items_of_types
List<NameValuePair> params = DeliveryParameterBuilder.params()
    // Gets items based on the types Product, Article, and News
    .filterIn("system.type", "product", "article", "news")
    .build();

ContentItemsListingResponse listingResponse = deliveryClient.getItems(params);
// EndDocSection
// DocSection: filtering_get_items_of_types
// Gets items based on the types Article, Product, and News
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterIn("system.type", "article", "product", "news")
    .build()
);
// EndDocSection

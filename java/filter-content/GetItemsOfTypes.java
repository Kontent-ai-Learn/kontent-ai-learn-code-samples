// DocSection: filtering_get_items_of_types
// Gets items based on the types Article, Product, and News
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterIn("system.type", "article", "product", "news")
    .build()
);
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection

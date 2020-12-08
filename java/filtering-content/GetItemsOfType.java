// DocSection: filtering_get_items_of_type
// Gets items of content type Product
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterEquals("system.type", "product")
    .build()
);
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection
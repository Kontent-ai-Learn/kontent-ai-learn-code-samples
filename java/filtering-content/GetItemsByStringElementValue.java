// DocSection: filtering_get_items_by_string
// Gets items whose Title element value equals to "Hello World"
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterEquals("elements.title", "Hello World")
    .build()
);
// To use the code for Android projects, see http://docs.kontent.ai/javarx
// EndDocSection

// Gets items of content type Product
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterEquals("system.type", "product")
    .build()
);

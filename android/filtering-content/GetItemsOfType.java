// DocSection: filtering_get_items_of_type
// Gets items of content type Product
CompletionStage<ContentItemsListingResponse> items = client.getItems(
    DeliveryParameterBuilder.params().filterEquals("system.type", "product").build()
);
    .equalsFilter("system.type", "product")
    .get()
    .getItems();
// EndDocSection
// DocSection: filtering_get_item_by_id
// Gets an item by its internal ID
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterEquals("system.id", "2f7288a1-cfc8-47be-9bf1-b1d312f7da18")
    .build()
);
// EndDocSection
// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane.
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterContains("elements.author", "jane_doe")
    .build()
);


// Gets items attributed to at least Jane, John, or both.
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterAny("elements.author", "jane_doe", "john_wick")
    .build()
);
// EndDocSection
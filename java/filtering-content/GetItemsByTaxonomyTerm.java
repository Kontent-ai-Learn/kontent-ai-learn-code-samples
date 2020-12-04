// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterContains("elements.tags", "kentico")
    .build()
);

// Gets items tagged with a list of specific tags
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterAll("elements.tags", "kontent", "headless")
    .build()
);

// Gets items tagged with at least one of multiple tags
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterAny("elements.tags", "football", "soccer")
    .build()
);
// EndDocSection
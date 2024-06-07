// Gets a list of items where the 'my_page' item is used in the 'navigation' element.
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterContains("elements.navigation", "my_page")
    .build()
);


// Gets items linked to at least Jane, John, or both.
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterAny("elements.author", "jane_doe", "john_wick")
    .build()
);

// Gets pages linking travel insurance as their subpage.
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterContains("elements.subpages", "travel_insurance")
    .build()
);

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterAny("elements.subpages", "travel_insurance", "car_insurance")
    .build()
);

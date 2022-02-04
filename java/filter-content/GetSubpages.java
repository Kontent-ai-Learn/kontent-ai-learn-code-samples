// DocSection: filtering_get_subpages
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
// To use the code for Android projects, see http://kontent.ai/learn/android
// EndDocSection
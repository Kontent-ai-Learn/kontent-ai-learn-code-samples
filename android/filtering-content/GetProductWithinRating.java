// DocSection: filtering_get_product_within_rating
// Gets items whose rating is at least 6.5 and at most 9
CompletionStage<ContentItemsListingResponse> items = client.getItems(
    DeliveryParameterBuilder.params().filterRange("elements.product_rating", "6.5", "9").build()
);
// EndDocSection
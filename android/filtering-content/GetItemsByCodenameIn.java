// DocSection: filtering_get_items_by_codename_in
// Gets three items by their codenames. The codenames are unique per project.
CompletionStage<ContentItemsListingResponse> items = client.getItems(
    DeliveryParameterBuilder.params()
        .filterIn("system.codename", "delivery_api", "get_content", "hello_world")
        .build()
);
// EndDocSection
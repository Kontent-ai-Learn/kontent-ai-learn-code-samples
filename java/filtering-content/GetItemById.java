// DocSection: filtering_get_item_by_id
// Gets an item by its internal ID
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

List<NameValuePair> params = DeliveryParameterBuilder.params()
        .filterEquals("system.id", "2f7288a1-cfc8-47be-9bf1-b1d312f7da18")
        .build();

CompletionStage<ContentItem> item = client.getItems(params)
        .thenApply(contentItemsListingResponse -> contentItemsListingResponse.getItems().get(0));
// EndDocSection
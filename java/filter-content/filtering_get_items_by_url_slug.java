// Gets items in default language with the URL slug element equal to 'sample-url-slug'
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterEquals("elements.url_slug", "sample-url-slug")
    .build()
);

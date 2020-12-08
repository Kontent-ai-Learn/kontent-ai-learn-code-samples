// DocSection: filtering_get_items_by_datetime
// Note: Date & time element values are provided by users and stored with minute precision. The system.last_modified value reflects Last content change to an item and is stored with ms precision.
// Gets items modified after April 9 2020, 9 am UTC+0
CompletionStage<ContentItemsListingResponse> items1 = client.getItems(
  DeliveryParameterBuilder.params()
    .filterGreaterThan("system.last_modified", "2020-05-09T09:00:00.000000Z")
    .build()
);

// Gets items released at or after April 9 2020, 7 am UTC+0
CompletionStage<ContentItemsListingResponse> items2 = client.getItems(
  DeliveryParameterBuilder.params()
    .filterGreaterThanEquals("system.release_date", "2020-05-09T07:00:00Z")
    .build()
);

// Gets items modified before April 5 2020 UTC+0. Last match would be at 2020-05-04T23:59:59.
CompletionStage<ContentItemsListingResponse> items3 = client.getItems(
  DeliveryParameterBuilder.params()
    .filterLessThan("system.last_modified", "2020-05-05")
    .build()
);

// Gets items released at or before April 5 2020 10:30 am UTC+0
CompletionStage<ContentItemsListingResponse> items4 = client.getItems(
  DeliveryParameterBuilder.params()
    .filterLessThanEquals("system.release_date", "2020-05-05T10:30:00Z")
    .build()
);
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection 
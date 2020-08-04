// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
List<NameValuePair> params1 = DeliveryParameterBuilder.params()
    .filterContains("elements.tags", "kontent")
    .build();
ContentItemsListingResponse listingResponse1 = deliveryClient.getItems(params1);

// Gets items tagged with a list of specific tags
List<NameValuePair> params2 = DeliveryParameterBuilder.params()
    .filterAll("elements.tags", "kontent", "headless")
    .build();
ContentItemsListingResponse listingResponse2 = deliveryClient.getItems(params2);

// Gets items tagged with at least one of multiple tags
List<NameValuePair> params3 = DeliveryParameterBuilder.params()
    .filterAny("elements.tags", "football", "soccer")
    .build();
ContentItemsListingResponse listingResponse3 = deliveryClient.getItems(params3);
// EndDocSection
// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new ContainsFilter("elements.tags", "kontent_ai")
);

// Gets items tagged with a list of specific tags
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new AllFilter("elements.tags", "kontent_ai", "platform")
);

// Gets items tagged with at least one tag from the list
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new AnyFilter("elements.tags", "modular", "platform")
);
// EndDocSection
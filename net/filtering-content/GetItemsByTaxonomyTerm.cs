// DocSection: filtering_get_items_by_taxonomy_term
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Get articles tagged with specific tag
  new ContainsFilter("elements.tags", "kentico")
);

DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  //Get articles tagged with any of the below tags
  new AnyFilter("elements.tags", "sport", "soccer")
);

DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  //Get articles tagged with all of the below tags
  new AllFilter("elements.tags", "mvc", "kontent", "headless")
);
// EndDocSection

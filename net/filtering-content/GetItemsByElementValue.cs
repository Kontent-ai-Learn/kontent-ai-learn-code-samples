// DocSection: filtering_get_items_by_element_value
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets items whose Article title element equals "Get started with MVC"
  new EqualsFilter("elements.article_title", "Get started with MVC")
);
// EndDocSection

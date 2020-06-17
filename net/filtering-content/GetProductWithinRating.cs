// DocSection: filtering_get_product_within_rating
DeliveryItemListingResponse<object> response = await _deliveryClient.GetItemsAsync<object>(
  // Gets products whose rating is at least 7 but no greater than 9
  new RangeFilter("elements.product_rating", "7", "9")
 );
 // EndDocSection

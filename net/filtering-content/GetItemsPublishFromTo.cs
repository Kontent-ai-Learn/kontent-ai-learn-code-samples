// DocSection: filtering_datetime_lte_gte
// system.last_modified value is stored with ms precision such as 2020-07-20T09:18:17.4857463Z
// Date&Time element value is stored with minute precision such as 2020-04-29T00:00:00Z
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  // Gets items modified after April 9 2020, 9 am UTC+0
  new GreaterThanFilter("system.last_modified", "2020-05-09T09:00:00.000000Z")
);

DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  // Gets items released at or after April 9 2020, 7 am UTC+0
  new GreaterThanOrEqualFilter("elements.release_date", "2020-05-09T07:00:00Z")
);

DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  // Gets items modified before April 5 2020 UTC+0
  // Last match would be at 2020-05-04T23:59:59
  new LessThanFilter("system.last_modified", "2020-05-05")
);

DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  // Gets items released at or before April 5 2020 10:30 am UTC+0
  new LessThanOrEqualFilter("elements.release_date", "2020-05-05T10:30:00Z")
);
// EndDocSection
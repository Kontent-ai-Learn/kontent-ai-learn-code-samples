// DocSection: filtering_get_items_by_datetime
// Note: Date & time element values are provided by users and stored with minute precision. The system.last_modified value reflects Last content change to an item and is stored with ms precision.
// Gets items modified after April 9 2020, 9 am UTC+0
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new GreaterThanFilter("system.last_modified", "2020-05-09T09:00:00.000000Z")
);

// Gets items released at or after April 9 2020, 7 am UTC+0
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new GreaterThanOrEqualFilter("elements.release_date", "2020-05-09T07:00:00Z")
);

// Gets items modified before April 5 2020 UTC+0. Last match would be at 2020-05-04T23:59:59.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new LessThanFilter("system.last_modified", "2020-05-05")
);

// Gets items released at or before April 5 2020 10:30 am UTC+0
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new LessThanOrEqualFilter("elements.release_date", "2020-05-05T10:30:00Z")
);
// EndDocSection 
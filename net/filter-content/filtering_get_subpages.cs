// Gets pages linking travel insurance as their subpage.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new ContainsFilter("elements.subpages", "travel_insurance")
);

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new AnyFilter("elements.subpages", "travel_insurance", "car_insurance")
);

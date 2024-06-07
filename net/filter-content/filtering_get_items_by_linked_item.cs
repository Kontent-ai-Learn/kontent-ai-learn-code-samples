// Gets a list of items where the 'my_page' item is used in the 'navigation' element.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new ContainsFilter("elements.navigation", "my_page")
);

// Gets items linked to at least Jane, John, or both.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new AnyFilter("elements.author", "jane_doe", "john_wick")
);

// Gets pages linking travel insurance as their subpage.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new ContainsFilter("elements.subpages", "travel_insurance")
);

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new AnyFilter("elements.subpages", "travel_insurance", "car_insurance")
);
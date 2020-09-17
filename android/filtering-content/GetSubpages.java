// DocSection: filtering_get_subpages
// Gets pages linking travel insurance as their subpage.
List<ContentItem> items = deliveryService.<ContentItem>items()
    .containsFilter("elements.subpages", Arrays.asList("travel_insurance"))
    .get()
    .getItems();

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
List<ContentItem> items = deliveryService.<ContentItem>items()
    .anyFilter("elements.subpages", Arrays.asList("travel_insurance", "car_insurance"))
    .get()
    .getItems();
// EndDocSection
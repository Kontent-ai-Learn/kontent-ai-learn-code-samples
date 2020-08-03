// DocSection: filtering_get_product_within_rating
// Gets items whose rating is at least 6.5 and at most 9
List<object> items = deliveryService.<object>items()
    .rangeFilter("elements.product_rating", "6.5", "9")
    .get()
    .getItems();
// EndDocSection
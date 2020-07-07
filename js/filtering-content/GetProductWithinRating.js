// DocSection: filtering_get_product_within_rating
deliveryClient.items()
  // Gets products whose rating is at least 7 but no greater than 9
  .rangeFilter("elements.product_rating", "7", "9")
// EndDocSection

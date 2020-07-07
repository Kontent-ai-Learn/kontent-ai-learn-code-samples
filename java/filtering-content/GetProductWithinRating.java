// DocSection: filtering_get_product_within_rating
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets products whose rating is at least 7 but no greater than 9
  .filterRange("elements.product_rating", "7", "9")
 // EndDocSection

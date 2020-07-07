// DocSection: filtering_get_product_within_rating
$items = $client->getItems((new QueryParams())
  // Gets products whose rating is at least 7 but no greater than 9
  ->range("elements.product_rating", "7", "9")
 // EndDocSection

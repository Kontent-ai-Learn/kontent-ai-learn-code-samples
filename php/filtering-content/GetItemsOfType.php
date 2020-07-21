// DocSection: filtering_get_items_of_type
$items = $deliveryClient->getItems((new QueryParams())
  // Gets items based on the type Product
  ->equals("system.type", "product")
// EndDocSection

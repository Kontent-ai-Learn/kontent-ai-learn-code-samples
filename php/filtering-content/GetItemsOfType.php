// DocSection: filtering_get_items_of_type
$items = $client->getItems((new QueryParams())
  // Gets items of content type Product
  ->equals("system.type", "product")
// EndDocSection

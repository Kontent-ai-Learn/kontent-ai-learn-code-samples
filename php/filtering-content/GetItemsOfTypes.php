// DocSection: filtering_get_items_of_types
$items = $client->getItems((new QueryParams())
  // Gets items of following content types
  ->in("system.type", "product", "article", "news")
// EndDocSection

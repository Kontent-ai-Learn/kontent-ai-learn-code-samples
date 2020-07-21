// DocSection: filtering_get_items_of_types
$items = $deliveryClient->getItems((new QueryParams())
  // Gets items based on the types Product, Article, and News
  ->in("system.type", "product", "article", "news")
// EndDocSection

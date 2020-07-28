<?
// DocSection: filtering_get_items_of_types
// Gets items based on the types Product, Article, and News
$items = $deliveryClient->getItems((new QueryParams())
  ->in('system.type', 'product', 'article', 'news'));
// EndDocSection
?>
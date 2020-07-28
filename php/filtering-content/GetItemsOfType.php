<?
// DocSection: filtering_get_items_of_type
// Gets items based on the type Product
$items = $deliveryClient->getItems((new QueryParams())
  ->equals('system.type', 'product'));
// EndDocSection
?>
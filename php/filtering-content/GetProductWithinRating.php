<?
// DocSection: filtering_get_product_within_rating
// Gets items whose rating is at least 6.5 and at most 9
$items = $client->getItems((new QueryParams())
  ->range('elements.product_rating', '6.5', '9')
// EndDocSection
?>
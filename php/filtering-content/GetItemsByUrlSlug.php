<?
// DocSection: filtering_get_items_by_url_slug
// Gets items whose URL slug equals to sample-url-slug
$items = $client->getItems((new QueryParams())
  ->equals('elements.url_slug', 'sample-url-slug')
// EndDocSection
?>
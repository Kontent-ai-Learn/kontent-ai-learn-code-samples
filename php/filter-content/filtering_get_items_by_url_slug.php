<?php
// Gets items in default language with the URL slug element equal to 'sample-url-slug'
$items = $client->getItems((new QueryParams())
  ->equals('elements.url_slug', 'sample-url-slug'));
?>
<?php
// DocSection: filtering_get_items_by_string
// Gets items whose Title element value equals to 'Hello World'
$items = $client->getItems((new QueryParams())
  ->equals('elements.title', 'Hello World'));
// EndDocSection
?>
<?php
// Gets items whose Title element value equals to 'Hello World'
$items = $client->getItems((new QueryParams())
  ->equals('elements.title', 'Hello World'));
?>
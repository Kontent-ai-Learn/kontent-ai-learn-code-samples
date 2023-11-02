<?php
// Gets items attributed to Jane.
$items = $client->getItems((new QueryParams())
  ->contains('elements.author', 'jane_doe'));

// Gets items attributed to at least Jane, John, or both.
$items = $client->getItems((new QueryParams())
  ->any('elements.author', ['jane_doe','john_wick']));
?>
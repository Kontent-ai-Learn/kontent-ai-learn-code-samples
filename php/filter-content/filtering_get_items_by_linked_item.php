<?php
// Gets a list of items where the 'my_page' item is used in the 'navigation' element.
$items = $client->getItems((new QueryParams())
  ->contains('elements.navigation', 'my_page'));

// Gets items linked to at least Jane, John, or both.
$items = $client->getItems((new QueryParams())
  ->any('elements.author', ['jane_doe','john_wick']));
?>

<?php
// Gets pages linking travel insurance as their subpage.
$items = $client->getItems((new QueryParams())
  ->contains('elements.subpages', 'travel_insurance'));

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
$items = $client->getItems((new QueryParams())
  ->any('elements.subpages', ['travel_insurance','car_insurance']));
?>
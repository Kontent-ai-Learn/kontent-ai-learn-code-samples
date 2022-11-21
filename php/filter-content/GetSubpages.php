<?php
// DocSection: filtering_get_subpages
// Gets pages linking travel insurance as their subpage.
$items = $client->getItems((new QueryParams())
  ->contains('elements.subpages', 'travel_insurance'));

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
$items = $client->getItems((new QueryParams())
  ->any('elements.subpages', ['travel_insurance','car_insurance']));
// EndDocSection
?>
// DocSection: filtering_get_items_by_linked_item
$items = $client->getItems((new QueryParams())
  // Gets items whose linked item has codename as one of specified values
  ->any(“elements.authors”, ["john_snow"], ["johnny_bravo"])

$items = $client->getItems((new QueryParams())
  // Gets items whose linked item has codename of certain value
  ->contains(“elements.authors”, ["joe_down"])
// EndDocSection

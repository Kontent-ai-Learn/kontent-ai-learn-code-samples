<?
// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane. Matched items may also reference other authors.
$items = $client->getItems((new QueryParams())
  ->contains("elements.author", ["jane_doe"])

// Gets items attributed to at least Jane, John, or both. Matched items may also reference other authors.
$items = $client->getItems((new QueryParams())
  ->any("elements.author", ["jane_doe"], ["john_wick"])
// EndDocSection
?>
<?
// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with a single tag
$items = $client->getItems((new QueryParams())
  ->contains("elements.tags", ["kontent"])

// Gets items tagged with multiple tags
$items = $client->getItems((new QueryParams())
  ->all("elements.tags", ["kontent"], ["headless"])

// Gets items tagged with at least one of multiple tags
$items = $client->getItems((new QueryParams())
  ->any("elements.tags", ["football"], ["soccer"])
// EndDocSection
?>
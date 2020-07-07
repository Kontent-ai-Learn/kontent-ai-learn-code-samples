// DocSection: filtering_get_items_by_taxonomy_term
$items = $client->getItems((new QueryParams())
  // Get articles tagged with specific tag
  ->contains("elements.tags", ["kentico"])

$items = $client->getItems((new QueryParams())
  /// Gets articles tagged with any of the below tags
  ->any("elements.tags", ["sport"], ["soccer"])

$items = $client->getItems((new QueryParams())
  // Gets articles tagged with all of the below tags
  ->all("elements.tags", ["mvc"], ["kontent"], ["headless"])
// EndDocSection

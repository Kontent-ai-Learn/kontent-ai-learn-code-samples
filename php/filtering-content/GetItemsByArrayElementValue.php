// DocSection: filtering_get_items_by_array_element_value
$items = $client->getItems((new QueryParams())
  // Get items where multiple choice has a specific value
  ->contains("elements.multiple_choice", ["value"])

$items = $client->getItems((new QueryParams())
  // Get items where multiple choice has any of the below values
  ->any("elements.multiple_choice", ["value1"], ["value2"])
// EndDocSection

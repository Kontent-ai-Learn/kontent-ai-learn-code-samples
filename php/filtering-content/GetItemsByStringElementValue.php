// DocSection: filtering_get_items_by_string_element_value
$items = $client->getItems((new QueryParams())
  // Gets items whose Article title element equals "Get started with MVC"
  ->equals("elements.article_title", "Get started with MVC")
// EndDocSection

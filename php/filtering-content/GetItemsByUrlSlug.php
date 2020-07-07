// DocSection: filtering_get_items_by_url_slug
$items = $client->getItems((new QueryParams())
  // Gets items whose URL Slug is as follows - this is same as filtering by text element value
  ->equals("elements.url_slug", "article-title")
// EndDocSection

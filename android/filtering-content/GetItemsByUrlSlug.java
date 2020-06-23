// DocSection: filtering_get_items_by_url_slug
List<object> items = deliveryService.<object>items()
  // Gets items whose URL Slug is as follows - this is same as filtering by text element value
  .equalsFilter("elements.url_slug", "article-title")
// EndDocSection

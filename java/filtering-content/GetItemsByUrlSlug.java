// DocSection: filtering_get_items_by_url_slug
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose URL Slug is as follows - this is same as filtering by text element value
  .filterEquals("elements.url_slug", "article-title")
// EndDocSection

// DocSection: filtering_get_items_by_taxonomy_term
delivery_client.items([
  // Get articles tagged with specific tag
  'elements.tags'.contains('kentico')
])

delivery_client.items([
  //Get articles tagged with any of the below tags
  'elements.tags'.any('sport', 'soccer')
])

delivery_client.items([
  //Get articles tagged with all of the below tags
  'elements.tags'.contains('mvc', 'kontent', 'headless')
])
// EndDocSection

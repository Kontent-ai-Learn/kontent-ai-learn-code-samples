// DocSection: filtering_get_items_of_types
delivery_client.items([
  // Gets items of following content types
  'system.type'.in('product', 'article', 'news')
])
// EndDocSection

// DocSection: filtering_get_item_by_id
delivery_client.items([
  // Gets items whose codename is one of the following
  'system.codename'.in('welcome_to_mvc', 'top_10_websites', 'kontent_best_practices')
])
// EndDocSection

// DocSection: filtering_get_items_by_codename_in
$items = $client->getItems((new QueryParams())
  // Gets items whose codename is one of the following
  ->in("system.codename", "welcome_to_mvc", "top_10_websites", "kontent_best_practices")
// EndDocSection

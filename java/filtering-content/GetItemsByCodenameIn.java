// DocSection: filtering_get_items_by_codename_in
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose codename is one of the following
  .filterIn("system.codename", "welcome_to_mvc", "top_10_websites", "kontent_best_practices")
// EndDocSection

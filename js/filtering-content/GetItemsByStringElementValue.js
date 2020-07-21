// DocSection: filtering_get_items_by_string_element_value
deliveryClient.items()
  // Gets items whose Article title element equals "Get started with MVC"
  .equalsFilter('elements.article_title', 'Get started with MVC')
// EndDocSection

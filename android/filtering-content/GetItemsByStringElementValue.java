// DocSection: filtering_get_items_its_linked_item
List<object> items = deliveryService.<object>items()
  // Gets items whose Article title element equals "Get started with MVC"
  .filterEquals("elements.article_title", "Get started with MVC")
// EndDocSection
// DocSection: filtering_get_items_of_type
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items based on the type Product
  .filterEquals("system.type", "product")
  .build();

List<ProductItem> items = deliveryClient.getItems(ProductItem.class, params);
// EndDocSection
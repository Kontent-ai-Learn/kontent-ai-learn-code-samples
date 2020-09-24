// DocSection: filtering_get_items_of_type
// Gets items based on the type Product
List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "product")
    .build();

CompletionStage<List<ProductItem>> items = deliveryClient.getItems(ProductItem.class, params);
// EndDocSection
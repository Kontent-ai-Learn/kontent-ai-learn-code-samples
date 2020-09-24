// DocSection: delivery_api_get_items
// Tip: Find more about Java SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .page(0, 10) // Skip none and limit to 10
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<List<ArticleItem>> items = client.getItems(ArticleItem.class, params);
// EndDocSection
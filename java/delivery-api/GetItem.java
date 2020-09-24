// DocSection: delivery_api_get_item
// Tip: Find more about Java SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

List<NameValuePair> params = DeliveryParameterBuilder.params().build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<ArticleItem> item = client.getItem("my_article", ArticleItem.class, params);
// EndDocSection
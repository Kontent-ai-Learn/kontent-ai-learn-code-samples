// DocSection: getting_content_filter_items
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<List<ArticleItem>> items = client.getItems(ArticleItem.class);
// EndDocSection
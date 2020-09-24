// DocSection: getting_localized_content_language
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params().language("es-ES").build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<ArticleItem> item = client.getItem("about_us", ArticleItem.class, params);
// EndDocSection
// DocSection: linked_content_get_article_with_author
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params().linkedItemsDepth(1).build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<SimpleArticleItem> item = client.getItem("the_origin_of_coffee", SimpleArticleItem.class, params);
// EndDocSection
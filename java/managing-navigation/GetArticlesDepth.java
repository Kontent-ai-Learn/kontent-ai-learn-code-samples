// DocSection: managing_navigation_articles_depth
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params().modularContentDepth(5).build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionsStage<ArticleItem> item = client.getItem("root_navigation_item", NavigationItemItem.class, params);
// EndDocSection
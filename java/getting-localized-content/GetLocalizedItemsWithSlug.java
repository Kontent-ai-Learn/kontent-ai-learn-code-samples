// DocSection: getting_localized_content_url_slug
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .language("es-ES")
    .filterEquals("system.type", "article")
    .filterEquals("elements.url_pattern", "acerda-de-nosotros")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<List<ArticleItem>> items = client.getItems(ArticleItem.class, params);
// EndDocSection
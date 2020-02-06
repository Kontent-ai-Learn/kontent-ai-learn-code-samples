// DocSection: delivery_api_get_items
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .projection("title", "summary", "post_date")
    .orderByDesc("elements.post_date")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
List<ArticleItem> items = client.getItems(ArticleItem.class, params);
// EndDocSection
// DocSection: delivery_api_get_items
// Tip: Find more about Java/JavaRx SDKs at https://developer.kenticocloud.com/docs/javaandroid
import com.kenticocloud.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .projection("title", "summary", "post_date")
    .orderByDesc("elements.post_date")
    .build();

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
List<ArticleItem> items = client.getItems(ArticleItem.class, params);
// EndDocSection
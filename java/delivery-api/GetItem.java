// DocSection: delivery_api_get_item
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params().projection("title", "summary", "post_date", "teaser_image", "related_articles").build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
ArticleItem item = client.getItem("on_roasts", ArticleItem.class, params);
// EndDocSection
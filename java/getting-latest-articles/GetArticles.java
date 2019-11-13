// DocSection: latest_articles_get_articles
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
List<ArticleItem> items = client.getItems(ArticleItem.class, params);
// EndDocSection
// DocSection: schedule_expiration_add_filter
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
List<ArticleItem> items = client.getItems(ArticleItem.class, params);

List<ArticleItem> publishedItems = items.stream()
    .filter(item ->
            (item.getExpireAt() > today || item.getExpireAt() == null))
    .collect(Collectors.toList());
// EndDocSection
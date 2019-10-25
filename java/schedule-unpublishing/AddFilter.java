// DocSection: schedule_unpublishing_add_filter
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("14372844-0a5d-434a-8423-605b8a631623");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
List<ArticleItem> items = client.getItems(ArticleItem.class, params);

List<ArticleItem> publishedItems = items.stream()
    .filter(item ->
            (item.getPublishUntil() > today || item.getPublishUntil() == null))
    .collect(Collectors.toList());
// EndDocSection
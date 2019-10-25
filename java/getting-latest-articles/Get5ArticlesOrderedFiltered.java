// DocSection: latest_articles_get_5articles_orderfilt
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .orderByDesc("elements.post_date")
    .page(null, 5)
    .projection("title", "teaser_image")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
List<ArticleItem> items = client.getItems(ArticleItem.class, params);
// EndDocSection
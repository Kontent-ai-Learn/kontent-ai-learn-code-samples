// DocSection: getting_localized_content_url_slug
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .language("es-ES")
    .filterEquals("system.type", "home")
    .filterEquals("elements.url_pattern", "inicio")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
List<HomeItem> items = client.getItems(HomeItem.class, params);
// EndDocSection
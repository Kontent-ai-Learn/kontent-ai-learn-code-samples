// DocSection: securing_public_access_get_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryOptions options = new DeliveryOptions();
options.setProjectId("975bf280-fd91-488c-994c-2f04416e5ee3");
options.setProductionApiKey("<YOUR_API_KEY>");

DeliveryClient client = new DeliveryClient(options);

ContentItemResponse item = client.getItem("on_roasts");
// EndDocSection
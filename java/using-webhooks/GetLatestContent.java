// DocSection: using_webhooks_get_latest_content
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryOptions deliveryOptions = new DeliveryOptions();
deliveryOptions.setProjectId("975bf280-fd91-488c-994c-2f04416e5ee3");
deliveryOptions.setWaitForLoadingNewContent(true);

DeliveryClient client = new DeliveryClient(deliveryOptions);

ContentItemResponse item = client.getItem("on_roasts");
// EndDocSection
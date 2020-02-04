// DocSection: using_webhooks_get_latest_content
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryOptions deliveryOptions = new DeliveryOptions();
deliveryOptions.setProjectId("<YOUR_PROJECT_ID>");
deliveryOptions.setWaitForLoadingNewContent(true);

DeliveryClient client = new DeliveryClient(deliveryOptions);

ContentItemResponse item = client.getItem("my_article");
// EndDocSection
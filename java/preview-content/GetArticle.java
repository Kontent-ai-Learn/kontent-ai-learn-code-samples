// DocSection: preview_content_get_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>", "<YOUR_PREVIEW_API_KEY>");

ContentItem item = client.getItem("on_roasts").item;
// EndDocSection
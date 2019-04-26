// DocSection: preview_content_get_article
import com.kenticocloud.delivery;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>", "<YOUR_PREVIEW_API_KEY>");

ContentItem item = client.getItem("on_roasts").item;
// EndDocSection
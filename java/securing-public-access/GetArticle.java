// DocSection: securing_public_access_get_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryOptions options = new DeliveryOptions();
options.setProjectId("<YOUR_PROJECT_ID>");
options.setProductionApiKey("<YOUR_API_KEY>");

DeliveryClient client = new DeliveryClient(options);

ContentItemResponse item = client.getItem("my_article");
// EndDocSection
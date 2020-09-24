// DocSection: securing_public_access_get_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryOptions options = new DeliveryOptions();
options.setProjectId("<YOUR_PROJECT_ID>");
options.setProductionApiKey("<YOUR_API_KEY>");

DeliveryClient client = new DeliveryClient(options);

CompletionStage<ContentItemResponse> item = client.getItem("my_article");
// EndDocSection
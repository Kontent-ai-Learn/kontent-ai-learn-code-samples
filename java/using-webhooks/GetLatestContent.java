// DocSection: using_webhooks_get_latest_content
// Tip: Find more about Java SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryOptions deliveryOptions = new DeliveryOptions();
deliveryOptions.setProjectId("<YOUR_PROJECT_ID>");
deliveryOptions.setWaitForLoadingNewContent(true);

DeliveryClient client = new DeliveryClient(deliveryOptions);

CompletionsStage<ContentItemResponse> item = client.getItem("my_article");
// EndDocSection
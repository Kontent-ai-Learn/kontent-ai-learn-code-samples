// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

DeliveryOptions deliveryOptions = new DeliveryOptions();
deliveryOptions.setProjectId("<YOUR_ENVIRONMENT_ID>");
deliveryOptions.setWaitForLoadingNewContent(true);

DeliveryClient client = new DeliveryClient(deliveryOptions);

CompletionsStage<ContentItemResponse> item = client.getItem("my_article");

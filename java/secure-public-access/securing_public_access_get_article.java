// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient with secure access key
DeliveryClient client = new DeliveryClient(
	DeliveryOptions.builder()
		.projectId("KONTENT_AI_ENVIRONMENT_ID")
		.productionApiKey("<YOUR_API_KEY>")
		.build()
);

// Gets the latest version of an item
CompletionStage<ContentItemResponse> item = client.getItem("my_article");

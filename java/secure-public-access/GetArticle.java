// DocSection: securing_public_access_get_article
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient with secure access key
DeliveryClient client = new DeliveryClient(
	DeliveryOptions.builder()
		.projectId("<YOUR_PROJECT_ID>")
		.productionApiKey("<YOUR_API_KEY>")
		.build()
);

// Gets the latest version of an item
CompletionStage<ContentItemResponse> item = client.getItem("my_article");
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection
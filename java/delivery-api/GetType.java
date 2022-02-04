// DocSection: delivery_api_get_type
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets a content type
CompletionStage<ContentType> type = client.getType("article");
// To use the code for Android projects, see http://kontent.ai/learn/android
// EndDocSection
// DocSection: delivery_api_get_type
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets a content type
CompletionStage<ContentType> type = client.getType("article");
// EndDocSection
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_ENVIRONMENT_ID>");

// Gets the "title" content element from the "article" type using a simple request
CompletionStage<Element> element = client.getContentTypeElement("article", "title");

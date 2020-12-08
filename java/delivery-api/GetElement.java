// DocSection: delivery_api_get_element
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets the "title" content element from the "article" type using a simple request
CompletionStage<Element> element = client.getContentTypeElement("article", "title");
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection
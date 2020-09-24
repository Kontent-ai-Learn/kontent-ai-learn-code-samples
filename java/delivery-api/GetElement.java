// DocSection: delivery_api_get_element
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

CompletionStage<Element> element = client.getContentTypeElement("article", "title");
// EndDocSection
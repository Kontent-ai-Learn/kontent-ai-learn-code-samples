// DocSection: delivery_api_get_element
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

Element element = client.getContentTypeElement("coffee", "processing");
// EndDocSection
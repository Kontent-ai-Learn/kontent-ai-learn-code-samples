// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params().modularContentDepth(1).build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
Page item = client.getItem("insurance_listing", Page.class, params);
// EndDocSection
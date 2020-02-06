// DocSection: delivery_api_get_types
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

List<NameValuePair> params = DeliveryParameterBuilder.params().page(null, 3).build();
ContentTypesListingResponse types = client.getTypes(params);
// EndDocSection
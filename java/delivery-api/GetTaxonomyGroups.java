// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.kenticocloud.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params().page(null, 3).build();

TaxonomyGroupListingResponse response = client.getTaxonomyGroups(params);
// EndDocSection
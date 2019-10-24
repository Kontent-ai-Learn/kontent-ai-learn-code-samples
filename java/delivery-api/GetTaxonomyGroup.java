// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

TaxonomyGroup taxonomyGroup = client.getTaxonomyGroup("personas");
// EndDocSection
// DocSection: getting_content_get_items
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .build();

ContentItemsListingResponse listingResponse = client.getItems();
// EndDocSection
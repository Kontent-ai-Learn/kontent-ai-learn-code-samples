// DocSection: getting_latest_articles_get_all
import com.kenticocloud.delivery;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .build();

ContentItemsListingResponse listingResponse = client.getItems(params);
// EndDocSection
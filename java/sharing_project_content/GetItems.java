// DocSection: sharing_project_content_get_items
import com.kenticocloud.delivery;

// Initializes the content delivery clients
DeliveryClient client1 = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");
DeliveryClient client2 = new DeliveryClient("368d5707-fb05-0146-fc0a-f85c5d1a264e");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .build();

// Gets content items from both projects
ContentItemsListingResponse listingResponse1 = client1.getItems();
ContentItemsListingResponse listingResponse2 = client2.getItems();
// EndDocSection
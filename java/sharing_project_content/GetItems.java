// DocSection: sharing_project_content_get_items
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

// Initializes the content delivery clients
DeliveryClient client1 = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");
DeliveryClient client2 = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .build();

// Gets content items from both projects
ContentItemsListingResponse listingResponse1 = client1.getItems();
ContentItemsListingResponse listingResponse2 = client2.getItems();

//Pass the length parameter and combine arrays
Object[] combined = new Object[listingResponse1.length + listingResponse2.length];
System.arraycopy(listingResponse1, 0, combined, 0, listingResponse1.length);
System.arraycopy(listingResponse2, 0, combined, listingResponse1.length, listingResponse2.length);
// EndDocSection
// DocSection: getting_content_get_items
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .build();

CompletionStage<ContentItemsListingResponse> listingResponse = client.getItems();
// EndDocSection
// DocSection: getting_content_get_items
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_ENVIRONMENT_ID>");

// Gets all content items
CompletionStage<ContentItemsListingResponse> listingResponse = client.getItems();
// EndDocSection
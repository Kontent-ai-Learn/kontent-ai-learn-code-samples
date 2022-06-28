// DocSection: getting_content_get_items
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets all content items
CompletionStage<ContentItemsListingResponse> listingResponse = client.getItems();
// EndDocSection
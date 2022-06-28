// DocSection: sharing_project_content_get_items
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes the content delivery clients
DeliveryClient client1 = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");
DeliveryClient client2 = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

// Gets content items from both projects
CompletionStage<CompletionStage<ContentItem[]>> result = client1.getItems()
    .thenApply(listingResponse1 -> client2.getItems()
        .thenApply(listingResponse2 -> {
            // Pass the length parameter and combine arrays
            ContentItem[] combined = new ContentItem[listingResponse1.getItems().size() + listingResponse2.getItems().size()];
            System.arraycopy(listingResponse1.getItems(), 0, combined, 0, listingResponse1.getItems().size() - 1);
            System.arraycopy(listingResponse2.getItems(), 0, combined, listingResponse1.getItems().size(), listingResponse2.getItems().size());
            return combined;
        })
    );
// EndDocSection
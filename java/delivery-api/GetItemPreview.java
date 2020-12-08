// DocSection: delivery_api_get_item_preview
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>", "<YOUR_PREVIEW_API_KEY>");

CompletionStage<ContentItem> item = client.getItem("my_article")
                .thenApply(contentItemResponse -> contentItemResponse.getItem());
// EndDocSection
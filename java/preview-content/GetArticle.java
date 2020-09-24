// DocSection: preview_content_get_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>", "<YOUR_PREVIEW_API_KEY>");

CompletionsStage<ContentItem> item = client.getItem("my_article").item;
// EndDocSection
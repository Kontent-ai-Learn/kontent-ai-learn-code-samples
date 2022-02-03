// DocSection: delivery_api_get_item_preview
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a Delivery client for preview
DeliveryClient client = new DeliveryClient(
  DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .previewApiKey("<YOUR_PREVIEW_API_KEY>")
    .usePreviewApi(true)
    .build()
);

// Registers the model class for articles
// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
client.registerType(Article.class);

// Gets an article
CompletionStage<Article> article = client.getItem("my_article", Article.class);
// To use the code for Android projects, see http://kontent.ai/learn/android
// EndDocSection
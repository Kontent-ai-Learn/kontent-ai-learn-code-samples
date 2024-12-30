// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient for preview
DeliveryClient client = new DeliveryClient(
    DeliveryOptions.builder()
        .projectId("KONTENT_AI_ENVIRONMENT_ID")
        .previewApiKey("KONTENT_AI_PREVIEW_API_KEY")
        .usePreviewApi(true)
        .build();
);

// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets the latest version of an item
CompletionStage<Article> article = client.getItem(
    "my_article",
    Article.class
);

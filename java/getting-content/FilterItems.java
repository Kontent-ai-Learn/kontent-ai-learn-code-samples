// DocSection: getting_content_filter_items
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets all articles
CompletionStage<List<ArticleItem>> items = client.getItems(
    ArticleItem.class, 
    DeliveryParameterBuilder.params()
        .filterEquals("system.type", "article")
        .build();
);
// EndDocSection
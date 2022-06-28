// DocSection: getting_content_filter_items
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets all articles
CompletionStage<List<Article>> items = client.getItems(
    Article.class, 
    DeliveryParameterBuilder.params()
        .filterEquals("system.type", "article")
        .build();
);
// EndDocSection
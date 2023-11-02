// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_ENVIRONMENT_ID>");

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets the 3 latest articles ordered by their last modified datetime value
CompletionStage<List<Article>> items = client.getItems(
    Article.class,
    DeliveryParameterBuilder.params()
        .filterEquals("system.type", "article")
        .page(null, 3)
        .orderByDesc("system.last_modified")
        .build()
);

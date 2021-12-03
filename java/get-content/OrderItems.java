// DocSection: getting_content_order_items
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
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
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection
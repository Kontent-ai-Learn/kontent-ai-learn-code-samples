// DocSection: delivery_api_get_items
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Registers the model class for articles
// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
client.registerType(Article.class);

// Gets 3 articles ordered by the "Post date" element
CompletionStage<List<Article>> articles = client.getItems(
    Article.class,
    DeliveryParameterBuilder.params()
        .page(null, 3)
        .orderByDesc("post_date")
        .build()
);
// To use the code for Android projects, see http://kontent.ai/learn/android
// EndDocSection
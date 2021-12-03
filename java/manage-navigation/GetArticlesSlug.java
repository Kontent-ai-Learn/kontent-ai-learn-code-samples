// DocSection: managing_navigation_articles_slugs
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets specific elements of all articles using a simple request
CompletionStage<List<Article>> articles = client.getItems(
    Article.class, 
    DeliveryParameterBuilder.params()
        .projection("title", "url")
        .build()
);
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection
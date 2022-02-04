// DocSection: managing_navigation_articles_slugs
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Registers the model class for navigation items
// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
client.registerType(NavigationItem.class);

// Gets navigation items and their linked items
CompletionStage<NavigationItem> root = client.getItem(
    "root_navigation_item",
     NavigationItem.class,
     DeliveryParameterBuilder.params()
        .linkedItemsDepth(5)
        .build()

// Registers the model class for articles
client.registerType(Article.class);

// Gets specific elements of all articles
CompletionStage<List<Article>> articles = client.getItems(
    Article.class, 
    DeliveryParameterBuilder.params()
        .projection("title", "url")
        .build()
);
// EndDocSection
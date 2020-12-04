// DocSection: managing_navigation_articles_depth
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for navigation items
client.registerType(NavigationItem.class);

// Gets navigation items and their linked items
CompletionStage<NavigationItem> root = client.getItem(
    "root_navigation_item",
     NavigationItem.class,
     DeliveryParameterBuilder.params()
        .linkedItemsDepth(5)
        .build()
);
// EndDocSection
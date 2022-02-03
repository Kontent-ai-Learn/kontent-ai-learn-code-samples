// DocSection: managing_navigation_articles_depth
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
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
// To use the code for Android projects, see http://kontent.ai/learn/android
// EndDocSection
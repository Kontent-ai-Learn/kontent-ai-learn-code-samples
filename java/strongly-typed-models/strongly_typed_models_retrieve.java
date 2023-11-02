// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for navigation items
client.registerType(Homepage.class);

CompletionStage<Homepage> homepageResult = client.getItem("hello_caas_world", Homepage.class);
// Use homepageResult
// homepageResult.thenAccept(homepage -> System.out.println(homepage.getHeadline())

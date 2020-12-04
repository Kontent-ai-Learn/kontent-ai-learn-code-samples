// DocSection: strongly_typed_models_retrieve
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for navigation items
client.registerType(Homepage.class);

CompletionStage<Homepage> homepageResult = client.getItem("hello_caas_world", Homepage.class);
// Use homepageResult
// homepageResult.thenAccept(homepage -> System.out.println(homepage.getHeadline())
// To use the code for Android projects, see http://docs.kontent.ai/javarx
// EndDocSection
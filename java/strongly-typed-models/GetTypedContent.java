// DocSection: strongly_typed_models_retrieve
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;
import java.lang.System;

// Gets a content item from Kentico Kontent by its codename and maps it to its strongly typed model
DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

CompletionStage<Homepage> homepageResult = client.getItem("hello_caas_world", Homepage.class);
// Use homepageResult
// homepageResult.thenAccept(homepage -> System.out.println(homepage.getHeadline())
// EndDocSection
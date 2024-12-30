// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Gets content items in Spanish without following language fallbacks
CompletionsStage<ContentItemsListingResponse> listingResponse = client.getItems(
    DeliveryParameterBuilder.params()
        .language("es-ES")
        .filterEquals("system.language", "es-ES")
        .build()
);
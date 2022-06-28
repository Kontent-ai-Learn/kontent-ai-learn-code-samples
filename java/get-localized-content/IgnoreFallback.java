// DocSection: language_fallbacks_ignore
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets the Spanish variant of all content items (while ignoring language fallbacks)
CompletionsStage<ContentItemsListingResponse> listingResponse = client.getItems(
    DeliveryParameterBuilder.params()
        .language("es-ES")
        .filterEquals("system.language", "es-ES")
        .build()
);
// EndDocSection

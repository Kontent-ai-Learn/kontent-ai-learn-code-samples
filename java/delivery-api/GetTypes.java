// DocSection: delivery_api_get_types
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets 3 content types
CompletionStage<ContentTypesListingResponse> types = client.getTypes(
    DeliveryParameterBuilder.params()
        .page(null, 3)
        .build()
    );
// EndDocSection
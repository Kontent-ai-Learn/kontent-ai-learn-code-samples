// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Gets 3 content types
CompletionStage<ContentTypesListingResponse> types = client.getTypes(
    DeliveryParameterBuilder.params()
        .page(null, 3)
        .build()
    );

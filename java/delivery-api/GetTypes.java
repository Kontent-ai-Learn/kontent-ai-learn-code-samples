// DocSection: delivery_api_get_types
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets 3 content types
CompletionStage<ContentTypesListingResponse> types = client.getTypes(
    DeliveryParameterBuilder.params()
        .page(null, 3)
        .build()
    );
// To use the code for Android projects, see http://docs.kontent.ai/android
// EndDocSection
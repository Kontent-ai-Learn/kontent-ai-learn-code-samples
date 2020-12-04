// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets 3 taxonomy groups
CompletionStage<List<TaxonomyGroup>> taxonomies = client.getTaxonomyGroups(
    DeliveryParameterBuilder.params()
        .page(null, 3)
        .build()
    ).thenApply(taxonomyGroupListingResponse -> taxonomyGroupListingResponse.getTaxonomies());
// To use the code for Android projects, see http://docs.kontent.ai/javarx
// EndDocSection
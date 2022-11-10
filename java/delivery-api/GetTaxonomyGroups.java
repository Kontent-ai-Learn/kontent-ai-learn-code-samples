// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets 3 taxonomy groups
CompletionStage<List<TaxonomyGroup>> taxonomies = client.getTaxonomyGroups(
    DeliveryParameterBuilder.params()
        .page(null, 3)
        .build()
    ).thenApply(taxonomyGroupListingResponse -> taxonomyGroupListingResponse.getTaxonomies());
// EndDocSection
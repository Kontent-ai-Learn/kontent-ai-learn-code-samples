// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

CompletionStage<TaxonomyGroup> taxonomyGroup = client.getTaxonomyGroup("personas");
// EndDocSection
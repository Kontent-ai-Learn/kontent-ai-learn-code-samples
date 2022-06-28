// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets a specific taxonomy group
CompletionStage<TaxonomyGroup> personas = client.getTaxonomyGroup("personas");
// EndDocSection
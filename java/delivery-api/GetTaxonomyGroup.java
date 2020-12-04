// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Gets a specific taxonomy group
CompletionStage<TaxonomyGroup> personas = client.getTaxonomyGroup("personas");
// To use the code for Android projects, see http://docs.kontent.ai/javarx
// EndDocSection
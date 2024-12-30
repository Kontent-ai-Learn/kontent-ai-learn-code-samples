// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Gets a specific taxonomy group
CompletionStage<TaxonomyGroup> personas = client.getTaxonomyGroup("personas");

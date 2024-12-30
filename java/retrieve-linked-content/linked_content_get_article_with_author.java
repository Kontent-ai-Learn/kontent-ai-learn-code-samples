// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for simple articles
client.registerType(SimpleArticle.class);

CompletionStage<SimpleArticle> item = client.getItem(
	"the_origin_of_coffee",
	SimpleArticle.class,
	DeliveryParameterBuilder.params()
		.linkedItemsDepth(1)
		.build()
);

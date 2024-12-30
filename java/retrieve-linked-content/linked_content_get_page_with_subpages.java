// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for articles
client.registerType(Page.class);

CompletionStage<Page> item = client.getItem(
	"insurance_listing",
	Page.class,
	DeliveryParameterBuilder.params()
		.linkedItemsDepth(1)
		.build()
);

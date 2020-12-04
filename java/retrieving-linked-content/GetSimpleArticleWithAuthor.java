// DocSection: linked_content_get_article_with_author
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for simple articles
client.registerType(SimpleArticle.class);

CompletionStage<SimpleArticle> item = client.getItem(
	"the_origin_of_coffee",
	SimpleArticle.class,
	DeliveryParameterBuilder.params()
		.linkedItemsDepth(1)
		.build()
);
// EndDocSection
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_ENVIRONMENT_ID>");

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets the Spanish variant of an article
CompletionStage<Article> item = client.getItem(
	"about_us",
	Article.class,
	DeliveryParameterBuilder.params()
		.language("es-ES")
		.build()
	
);

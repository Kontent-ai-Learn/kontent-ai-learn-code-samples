// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Registers the model class for articles
// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
client.registerType(Article.class);

// Gets an article
CompletionStage<Article> article = client.getItem("my_article", Article.class);

// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
// Registers the model class for articles
client.registerType(Article.class);

// Filters all articles to find the Spanish variant by its URL slug
CompletionStage<List<Article>> items = client.getItems(
    Article.class,
    DeliveryParameterBuilder.params()
        .language("es-ES")
        .filterEquals("system.type", "article")
        .filterEquals("elements.url_pattern", "acerda-de-nosotros")
        .build();
);
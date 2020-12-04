// DocSection: getting_localized_content_url_slug
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets the Spanish variant of an "About us" content item that has "acerda-de-nosotros" in its "URL pattern" element
CompletionStage<List<Article>> items = client.getItems(
    Article.class,
    DeliveryParameterBuilder.params()
        .language("es-ES")
        .filterEquals("system.type", "article")
        .filterEquals("elements.url_pattern", "acerda-de-nosotros")
        .build();
);
// EndDocSection
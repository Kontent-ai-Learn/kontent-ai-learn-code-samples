// DocSection: language_fallbacks_ignore
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .language("es-ES")
    .filterEquals("system.language", "es-ES")
    .build();

CompletionsStage<ContentItemsListingResponse> listingResponse = client.getItems();
// EndDocSection

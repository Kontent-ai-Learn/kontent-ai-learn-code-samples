// DocSection: schedule_expiration_add_filter
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "landing_page")
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<List<LandingPageItem>> items = client.getItems(LandingPageItem.class, params)
    .thenApply(landingPageItems -> landingPageItems.stream()
        .filter(item ->
            (item.getExpireAt().compareTo(ZonedDateTime.now()) > 0 || item.getExpireAt() == null))
        .collect(Collectors.toList()));
// EndDocSection
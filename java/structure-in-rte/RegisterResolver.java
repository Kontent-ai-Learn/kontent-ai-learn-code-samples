// DocSection: structure_in_rte_register_resolver
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");
client.registerInlineContentItemsResolver(new TweetInlineContentItemsResolver());
// EndDocSection
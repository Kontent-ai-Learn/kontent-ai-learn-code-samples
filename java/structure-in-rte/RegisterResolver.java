// DocSection: structure_in_rte_register_resolver
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
DeliveryClient client = new DeliveryClient("<YOUR_ENVIRONMENT_ID>");
client.registerInlineContentItemsResolver(new TweetInlineContentItemsResolver());
// EndDocSection
// DocSection: structure_in_rte_register_resolver
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7"); 
client.registerInlineContentItemsResolver(new TweetInlineContentItemsResolver());
// EndDocSection
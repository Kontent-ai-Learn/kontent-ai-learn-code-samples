// DocSection: structure_in_rte_register_resolver
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
DeliveryClient client = new DeliveryClient("e6d2946e-0e24-003f-a397-9d2d458c6d6e"); 
client.registerInlineContentItemsResolver(new TweetInlineContentItemsResolver());
// EndDocSection
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");
client.registerInlineContentItemsResolver(new TweetInlineContentItemsResolver());

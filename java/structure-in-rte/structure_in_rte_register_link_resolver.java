// You can also register lambdas with the DeliveryClient as the resolvers are functional interfaces: https://kontent.ai/learn/java-register-resolver

// Sets the resolver as an optional dependency of the DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID"); 
client.setContentLinkUrlResolver(new CustomContentLinkUrlResolver());
client.setBrokenLinkUrlResolver(new CustomBrokenContentLinkUrlResolver());

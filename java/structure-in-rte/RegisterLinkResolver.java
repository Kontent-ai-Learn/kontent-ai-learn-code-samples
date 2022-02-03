// DocSection: structure_in_rte_register_link_resolver
// You can also register lambdas with the DeliveryClient as the resolvers are functional interfaces: https://kontent.ai/learn/java-register-resolver

// Sets the resolver as an optional dependency of the DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>"); 
client.setContentLinkUrlResolver(new CustomContentLinkUrlResolver());
client.setBrokenLinkUrlResolver(new CustomBrokenContentLinkUrlResolver());
// EndDocSection
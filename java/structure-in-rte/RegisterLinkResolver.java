// DocSection: structure_in_rte_register_link_resolver
// You can also register lambdas with the DeliveryClient as the resolvers are functional interfaces: https://github.com/Kentico/kontent-delivery-sdk-java/wiki/Resolving-links-to-content-items#registering-a-resolver

// Sets the resolver as an optional dependency of the DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>"); 
client.setContentLinkUrlResolver(new CustomContentLinkUrlResolver());
client.setBrokenLinkUrlResolver(new CustomBrokenContentLinkUrlResolver());
// EndDocSection
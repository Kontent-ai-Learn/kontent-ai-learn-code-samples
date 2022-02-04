// DocSection: structure_in_rte_register_link_resolver
// You can also register the resolver in IServiceCollection or another framework for dependency injection: https://kontent.ai/learn/net-register-resolver
using Kentico.Kontent.Delivery;

IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("<YOUR_PROJECT_ID>")
    // Registers the resolver
    .WithContentLinkUrlResolver(new CustomContentLinkUrlResolver())
    .Build();
// EndDocSection
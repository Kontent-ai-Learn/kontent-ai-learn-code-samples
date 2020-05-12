// DocSection: structure_in_rte_register_link_resolver
// You can also register it in IServiceCollection or another framework for dependency injection: https://docs.kontent.ai/net-register-resolver
using Kentico.Kontent.Delivery;

// Sets the resolver as an optional dependency of the `IDeliveryClient` instance
IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("<YOUR_PROJECT_ID>")
    .WithContentLinkUrlResolver(new CustomContentLinkUrlResolver())
    .Build();
// EndDocSection
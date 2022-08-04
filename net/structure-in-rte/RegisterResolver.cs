// DocSection: structure_in_rte_register_resolver
// You can also register it in IServiceCollection or another framework for dependency injection: https://github.com/Kentico/delivery-sdk-net/wiki/String-based-rendering-of-items-in-Rich-text#registering-a-resolver

using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.InlineContentItems;

IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("<YOUR_PROJECT_ID>")
    // Registers a content item resolver for tweets
    .WithInlineContentItemsResolver(new TweetResolver())
    // Registers the generated strongly typed models
    .WithTypeProvider(new CustomTypeProvider())
    .Build();
// EndDocSection
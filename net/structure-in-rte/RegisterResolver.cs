// DocSection: structure_in_rte_register_resolver
// You can also register it in IServiceCollection or another framework for dependency injection: https://github.com/kontent-ai/delivery-sdk-net/blob/master/docs/customization-and-extensibility/rich-text/string-based-linked-items-rendering.md#registering-a-resolver

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
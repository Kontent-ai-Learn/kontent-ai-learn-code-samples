// DocSection: structure_in_rte_register_resolver
// You can also register it in IServiceCollection or another framework for dependency injection: https://github.com/Kentico/delivery-sdk-net/wiki/String-based-rendering-of-items-in-Rich-text#registering-a-resolver

using KenticoCloud.Delivery;
using KenticoCloud.Delivery.InlineContentItems;

...

IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("e6d2946e-0e24-003f-a397-9d2d458c6d6e")
    // Registers an inline content item resolver for Tweets
    .WithInlineContentItemsResolver(new TweetResolver())
    // Registers strongly typed models
    .WithTypeProvider(new CustomTypeProvider())
    .Build();
// EndDocSection
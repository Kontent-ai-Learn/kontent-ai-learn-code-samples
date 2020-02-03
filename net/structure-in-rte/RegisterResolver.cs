// DocSection: structure_in_rte_register_resolver
// You can also register it in IServiceCollection or another framework for dependency injection: https://github.com/Kentico/delivery-sdk-net/wiki/String-based-rendering-of-items-in-Rich-text#registering-a-resolver

using Kentico.Kontent.Delivery;
using Kentico.Kontent.Delivery.InlineContentItems;

...

IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
    // Registers an inline content item resolver for Tweets
    .WithInlineContentItemsResolver(new TweetResolver())
    // Registers strongly typed models
    .WithTypeProvider(new CustomTypeProvider())
    .Build();
// EndDocSection
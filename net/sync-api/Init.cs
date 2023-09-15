// DocSection: sync_api_initialize_sync
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("<YOUR_ENVIRONMENT_ID>")
    .Build();

// Gets the continuation token based on the given parameters
IDeliverySyncInitResponse response = await client.PostSyncInitAsync(
    new LanguageParameter("en-US"),
    new EqualsFilter("system.type", "article"),
    new NotEqualsFilter("system.collection", "default"));
    
string continuationToken = response.ApiResponse.ContinuationToken;
// EndDocSection
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
    .Build();

// Gets the continuation token based on the given parameters
IDeliverySyncV2Response response = await client.PostSyncV2InitAsync()
    
string continuationToken = response.ApiResponse.ContinuationToken;
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
    .Build();

// Gets a list of recently changed content items
IDeliverySyncResponse response = await client.GetSyncAsync("KONTENT_AI_CONTINUATION_TOKEN");
IList<ISyncItem> syncItems = response.SyncItems;
await client.GetSyncAsync("token");
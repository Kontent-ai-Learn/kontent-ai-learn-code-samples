// DocSection: sync_api_synchronize_changes
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("<YOUR_PROJECT_ID>")
    .Build();

// Gets a list of recently changed content items
IDeliverySyncResponse response = await client.GetSyncAsync("<CONTINUATION_TOKEN>");
IList<ISyncItem> syncItems = response.SyncItems;
await client.GetSyncAsync("token");
// EndDocSection
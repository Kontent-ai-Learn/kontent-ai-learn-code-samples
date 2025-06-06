// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
    .Build();

// Gets a list of recently changed content items
IDeliverySyncResponse response = await client.GetSyncV2Async("KONTENT_AI_CONTINUATION_TOKEN");
IList<ISyncV2Item> syncItems = response.SyncItems;
IList<ISyncV2ContentType> syncTypes = response.SyncTypes;
IList<ISyncV2Taxonomy> syncTaxonomies = response.SyncTaxonomies;
IList<ISyncV2Language> syncLanguages = response.SyncLanguages;
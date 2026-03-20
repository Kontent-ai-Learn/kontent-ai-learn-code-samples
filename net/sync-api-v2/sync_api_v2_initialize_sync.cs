// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Sync;
using Kontent.Ai.Sync.Abstractions;
using Microsoft.Extensions.DependencyInjection;

// Tip: Use DI to create Sync client
var services = new ServiceCollection();
services.AddSyncClient(options =>
{
    options.EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID";
    options.ApiMode = ApiMode.Preview;
    options.ApiKey = "KONTENT_AI_PREVIEW_API_KEY";
});
using var serviceProvider = services.BuildServiceProvider();
var syncClient = serviceProvider.GetRequiredService<ISyncClient>();

// Initializes Sync API v2 and gets the initial sync token.
var result = await syncClient.InitializeSyncAsync();
if (!result.IsSuccess)
{
    throw new InvalidOperationException(result.Error?.Message ?? "Sync init failed.");
}

string? syncToken = result.SyncToken;
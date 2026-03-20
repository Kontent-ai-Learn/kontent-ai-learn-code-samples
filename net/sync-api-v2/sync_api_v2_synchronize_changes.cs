// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using System;
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

// Gets a page of changes since the last stored sync token.
var result = await syncClient.GetDeltaAsync("KONTENT_AI_SYNC_TOKEN");
if (!result.IsSuccess)
{
    throw new InvalidOperationException(result.Error?.Message ?? "Sync failed.");
}

var delta = result.Value;
var syncItems = delta.Items;
var syncTypes = delta.Types;
var syncTaxonomies = delta.Taxonomies;
var syncLanguages = delta.Languages;

// Persist this token and use it in the next synchronization call.
string? nextSyncToken = result.SyncToken;
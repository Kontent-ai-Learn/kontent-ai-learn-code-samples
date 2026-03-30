// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Sync;
using Kontent.Ai.Sync.Abstractions;

// Register a Sync client
services.AddSyncClient(options =>
{
    options.EnvironmentId = "your-environment-id";
    options.ApiMode = ApiMode.Preview;
    options.ApiKey = "your-preview-api-key";
});

// Resolve via DI (e.g., constructor injection)
// ISyncClient syncClient = ...

// Gets a page of changes since the last stored sync token.
var result = await syncClient.GetDeltaAsync("your-sync-token");
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

// For other means of creating a client, see https://github.com/kontent-ai/sync-sdk-net#quick-start
await using var client = SyncClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UsePreviewApi("your-preview-api-key")
        .Build())
    .Build();

// Gets a page of changes since the last stored sync token.
var result = await client.GetDeltaAsync("your-sync-token");
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

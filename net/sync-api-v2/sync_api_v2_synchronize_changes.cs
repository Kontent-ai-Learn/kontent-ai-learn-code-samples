// Or register it through DI with services.AddSyncClient()
using var client = SyncClient.Create(new SyncOptions { EnvironmentId = "your-environment-id" }
    .UsePreviewApi("your-preview-api-key"));

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

// Once the changes are processed, persist this token and use it in the next synchronization call.
string nextSyncToken = result.SyncToken;

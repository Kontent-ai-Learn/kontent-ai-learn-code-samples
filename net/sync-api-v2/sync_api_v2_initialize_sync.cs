// Or register it through DI with services.AddSyncClient()
using var client = SyncClient.Create(new SyncOptions { EnvironmentId = "your-environment-id" }
    .UsePreviewApi("your-preview-api-key"));

// Initializes Sync API v2 and gets the initial sync token.
var result = await client.InitializeSyncAsync();
if (!result.IsSuccess)
{
    throw new InvalidOperationException(result.Error?.Message ?? "Sync init failed.");
}

string syncToken = result.SyncToken;

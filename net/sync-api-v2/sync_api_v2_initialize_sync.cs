// Register a Sync client
services.AddSyncClient(options =>
{
    options.EnvironmentId = "your-environment-id";
    options.ApiMode = ApiMode.Preview;
    options.ApiKey = "your-preview-api-key";
});

// Resolve via DI (e.g., constructor injection)
// ISyncClient syncClient = ...

// Initializes Sync API v2 and gets the initial sync token.
var result = await syncClient.InitializeSyncAsync();
if (!result.IsSuccess)
{
    throw new InvalidOperationException(result.Error?.Message ?? "Sync init failed.");
}

string? syncToken = result.SyncToken;

// For other means of creating a client, see https://github.com/kontent-ai/sync-sdk-net#quick-start
await using var client = SyncClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UsePreviewApi("your-preview-api-key")
        .Build())
    .Build();

// Initializes Sync API v2 and gets the initial sync token.
var result = await client.InitializeSyncAsync();
if (!result.IsSuccess)
{
    throw new InvalidOperationException(result.Error?.Message ?? "Sync init failed.");
}

string? syncToken = result.SyncToken;

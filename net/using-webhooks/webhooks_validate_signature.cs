// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.AspNetCore.Webhooks;
using Microsoft.AspNetCore.Builder;

// Validates the 'X-Kontent-ai-Signature' header against the raw webhook payload.
// Rejects requests to /webhooks that Kontent.ai did not sign with the webhook's secret.
// Requires the Kontent.Ai.AspNetCore package; the secret goes to "WebhookOptions:Secret" in appsettings.json.
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseWebhookSignatureValidator(
    context => context.Request.Path.StartsWithSegments("/webhooks", StringComparison.OrdinalIgnoreCase),
    builder.Configuration.GetSection(nameof(WebhookOptions)));
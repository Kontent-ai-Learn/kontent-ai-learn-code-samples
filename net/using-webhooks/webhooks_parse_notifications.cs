// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.AspNetCore.Webhooks;
using Kontent.Ai.AspNetCore.Webhooks.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// Requires the Kontent.Ai.AspNetCore package; the webhook's secret goes to "WebhookOptions:Secret" in appsettings.json
var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<WebhookOptions>(builder.Configuration.GetSection(nameof(WebhookOptions)));

var app = builder.Build();

// Rejects requests to /webhooks with a missing or invalid signature with 401 Unauthorized
app.UseWebhookSignatureValidator(context => context.Request.Path.StartsWithSegments("/webhooks"));

// Notifications that pass validation bind to typed models
app.MapPost("/webhooks/kontent", (WebhookNotification notification) =>
{
    foreach (var webhook in notification.Notifications)
    {
        if (webhook.Message.ObjectType == WebhookObjectTypes.ContentItem)
        {
            Console.WriteLine($"Content item: {webhook.Data.System.Name}");
        }
    }

    return Results.Ok();
});

app.Run();
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Initializes a delivery client for previewing content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("<YOUR_ENVIRONMENT_ID>")
        .UsePreviewApi("<YOUR_PREVIEW_API_KEY>")
        .Build())
    .Build();

// Generate strongly typed models via https://github.com/kontent-ai/model-generator-net
IDeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("my_article");
Article item = response.Item;

// DocSection: preview_content_detect_environment
using Kentico.Kontent.Delivery;

// TODO: Determine whether the app is running in a preview environment
bool isPreview = ...;

// Prepares connection options for the content delivery client
DeliveryOptions options = new DeliveryOptions()
{
    ProjectId = "975bf280-fd91-488c-994c-2f04416e5ee3",
    PreviewApiKey = "<YOUR_PREVIEW_API_KEY>",
    // Determines whether to use the Delivery Preview API
    UsePreviewApi = isPreview
};

// Ensures the specified options configuration is valid
options.Validate();

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(_ => options)
    .Build();
// EndDocSection
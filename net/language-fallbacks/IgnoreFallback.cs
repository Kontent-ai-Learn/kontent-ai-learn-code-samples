// DocSection: language_fallbacks_ignore
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets the American English variant of all articles and ignores language fallbacks
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new LanguageParameter("en-US"),
    new EqualsParameter("system.language", "en-US")
    new EqualsParameter("system.type", "article")
    );

var items = response.Items;
// EndDocSection
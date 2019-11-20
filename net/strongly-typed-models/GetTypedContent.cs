// DocSection: strongly_typed_models_retrieve
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;
using KenticoKontentModels;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets a content item by codename and maps it to the item's strongly typed model
DeliveryItemResponse<Homepage> response = await client.GetItemAsync<Homepage>("hello_headless_world");

var homepage = response.Item;
// Use homepage
// Console.WriteLine(homepage.Headline);
// EndDocSection
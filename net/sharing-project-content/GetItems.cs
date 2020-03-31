// DocSection: sharing_project_content_get_items
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

public class Startup
{
    public IConfigurationRoot Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // Registers named clients based on the DeliveryOptions objects defined in appsettings.json
		// See https://docs.kontent.ai/net-register-multiple-clients for details
        services.AddDeliveryClient("first_project", Configuration, "DeliveryOptionsForFirstProject");
        services.AddDeliveryClient("second_project", Configuration, "DeliveryOptionsForSecondProject");
    }
}

public class YourController : Controller
{
    private IDeliveryClient client1;
    private IDeliveryClient client2;

    public YourController(IDeliveryClientFactory deliveryClientFactory)
    {
		// Creates instances of Delivery clients based on their names
        client1 = deliveryClientFactory.Get("first_project");
        client2 = deliveryClientFactory.Get("second_project");

        // Gets content items from both projects
        // Using the generic <object> produces strongly typed objects based on "system.type"
        var response1 = await client1.GetItemsAsync<object>();
        var response2 = await client2.GetItemsAsync<object>();

        // Merges the responses
        IReadOnlyList<ContentItem> items = response1.Items.Concat(response2.Items).ToArray();
    }
}
// EndDocSection
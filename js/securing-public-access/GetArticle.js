// DocSection: securing_public_access_get_article
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    globalQueryConfig:  {
        useSecuredMode: true, // Queries the Delivery API using secure access.
    },
    secureApiKey: '<YOUR_API_KEY>',
    typeResolvers: [
        new KontentDelivery.TypeResolver('article', (rawData) => new Article)
    ]
});

deliveryClient.item('on_roasts')
    .toObservable()
    .subscribe(response => console.log(response));

// EndDocSection
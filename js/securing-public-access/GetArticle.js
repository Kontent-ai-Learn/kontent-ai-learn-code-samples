// DocSection: securing_public_access_get_article
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '<YOUR_PROJECT_ID>',
    globalQueryConfig:  {
        useSecuredMode: true, // Queries the Delivery API using secure access.
    },
    secureApiKey: '<YOUR_API_KEY>',
    typeResolvers: [
        new KontentDelivery.TypeResolver('article', (rawData) => new Article)
    ]
});

deliveryClient.item('my_article')
    .toObservable()
    .subscribe(response => console.log(response));

// EndDocSection
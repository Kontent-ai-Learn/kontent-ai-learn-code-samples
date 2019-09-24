// DocSection: securing_public_access_get_article
const KenticoCloud = require('kentico-cloud-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    globalQueryConfig:  {
        useSecuredMode: true, // Queries the Delivery API using secure access.
    },
    secureApiKey: '<YOUR_API_KEY>',
    typeResolvers: [
        new KenticoCloud.TypeResolver('article', (rawData) => new Article)
    ]
});

deliveryClient.item('on_roasts')
    .toObservable()
    .subscribe(response => console.log(response));

// EndDocSection
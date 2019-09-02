// DocSection: securing_public_access_get_article
const KenticoCloud = require('kentico-cloud-delivery');

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
class Article extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    // globalQueryConfig sets default values for each config
    // which can be overriden by individual queries
    globalQueryConfig:  {
        useSecuredMode: true, // enables secured mode by default
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
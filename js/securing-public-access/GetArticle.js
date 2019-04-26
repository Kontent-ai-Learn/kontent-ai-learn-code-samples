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
    enableSecuredMode: true,
    securedApiKey: "<YOUR_API_KEY>",
    typeResolvers: [
        new KenticoCloud.TypeResolver('article', () => new Article)
    ]
});

deliveryClient.item('on_roasts')
    .getObservable()
    .subscribe(response => console.log(response));

// EndDocSection
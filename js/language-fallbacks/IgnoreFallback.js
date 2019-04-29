// DocSection: language_fallbacks_ignore
// const KenticoCloud = require('kentico-cloud-delivery');

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
class Article extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
        new KenticoCloud.TypeResolver('article', () => new Article())
    ]
});

deliveryClient.items()
    .type('article')
    .languageParameter('en-US')
    .equalsFilter('system.language', 'en-US')
    .getObservable()
    .subscribe(response => console.log(response.items));
// EndDocSection
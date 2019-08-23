// DocSection: delivery_api_get_items
// Tip: Find more about JS/TS SDKs at https://developer.kenticocloud.com/docs/javascript
const KenticoCloud = require('kentico-cloud-delivery');

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
    .elementsParameter(['title', 'summary', 'post_date'])
    .orderParameter('elements.post_date', KenticoCloud.SortOrder.desc)
    .getObservable()
    .subscribe(response => console.log(response));
// EndDocSection
// DocSection: delivery_api_get_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
        new KontentDelivery.TypeResolver('article', (rawData) => new Article())
    ]
});

deliveryClient.items()
    .type('article')
    .elementsParameter(['title', 'summary', 'post_date'])
    .orderParameter('elements.post_date', KontentDelivery.SortOrder.desc)
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
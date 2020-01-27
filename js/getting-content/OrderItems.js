// DocSection: getting_content_order_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b',
    typeResolvers: [
        new KontentDelivery.TypeResolver('article', (rawData) => new Article())
    ]
});

deliveryClient.items()
    .type('article')
    .limitParameter(3)
    .orderParameter('system.last_modified', KontentDelivery.SortOrder.desc)
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
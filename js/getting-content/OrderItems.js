// DocSection: getting_content_order_items
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
    .limitParameter(3)
    .orderParameter('system.last_modified', KontentDelivery.SortOrder.desc)
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
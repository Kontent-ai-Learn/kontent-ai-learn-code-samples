// DocSection: getting_content_order_items
const KenticoCloud = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
        new KenticoCloud.TypeResolver('article', (rawData) => new Article())
    ]
});

deliveryClient.items()
    .type('article')
    .limitParameter(3)
    .orderParameter('system.last_modified', KenticoCloud.SortOrder.desc)
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
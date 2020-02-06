// DocSection: delivery_api_get_item
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
    typeResolvers: [
        new KontentDelivery.TypeResolver('article', (rawData) => new Article())
    ]
});

deliveryClient.item('on_roasts')
    .elementsParameter(['title', 'summary', 'post_date', 'teaser_image', 'related_articles'])
    .toObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection
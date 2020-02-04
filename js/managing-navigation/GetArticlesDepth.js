// DocSection: managing_navigation_articles_depth
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class NavigationItem extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
    typeResolvers: [
        new KontentDelivery.TypeResolver('navigation_item', (rawData) => new NavigationItem)
    ]
});

deliveryClient.item('root_navigation_item')
    .depthParameter(5)
    .toObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection
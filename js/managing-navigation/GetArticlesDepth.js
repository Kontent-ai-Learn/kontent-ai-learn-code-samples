// DocSection: managing_navigation_articles_depth
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class NavigationItem extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '24246f25-946d-4ab4-b170-fadef22fe7b2',
    typeResolvers: [
        new KontentDelivery.TypeResolver('navigation_item', (rawData) => new NavigationItem)
    ]
});

deliveryClient.item('root_navigation_item')
    .depthParameter(5)
    .toObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection
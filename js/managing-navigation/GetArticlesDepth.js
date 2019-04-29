// DocSection: managing_navigation_articles_depth
const KenticoCloud = require('kentico-cloud-delivery');

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
class NavigationItem extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '24246f25-946d-4ab4-b170-fadef22fe7b2',
    typeResolvers: [
        new KenticoCloud.TypeResolver('navigation_item', () => new NavigationItem)
    ]
});

deliveryClient.item('root_navigation_item')
    .depthParameter(5)
    .getObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection
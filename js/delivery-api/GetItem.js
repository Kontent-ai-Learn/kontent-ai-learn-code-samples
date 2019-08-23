// DocSection: delivery_api_get_item
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

deliveryClient.item('on_roasts')
    .elementsParameter(['title', 'summary', 'post_date', 'teaser_image', 'related_articles'])
    .getObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection
// DocSection: preview_content_get_article
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
    previewApiKey: '<YOUR_PREVIEW_API_KEY>',
    globalQueryConfig:  {
        usePreviewMode: true, // Queries the Delivery Preview API.
    },
    typeResolvers: [
        new KontentDelivery.TypeResolver('article', (rawData) => new Article)
    ]
});

deliveryClient.item('my_article')
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
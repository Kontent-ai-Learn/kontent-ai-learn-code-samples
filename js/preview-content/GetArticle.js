// DocSection: preview_content_get_article
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

deliveryClient.item('on_roasts')
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
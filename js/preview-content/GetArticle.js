// DocSection: preview_content_get_article
const KenticoCloud = require('kentico-cloud-delivery');

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
class Article extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '<YOUR_PROJECT_ID>',
    enablePreviewMode: true,
    previewApiKey: "<YOUR_PREVIEW_API_KEY>",
    typeResolvers: [
        new KenticoCloud.TypeResolver('article', () => new Article)
    ]
});

deliveryClient.item('on_roasts')
    .getObservable()
    .subscribe(response => console.log(response));
// EndDocSection
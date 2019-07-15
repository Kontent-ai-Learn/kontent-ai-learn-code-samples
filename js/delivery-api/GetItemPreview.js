// DocSection: delivery_api_get_item_preview
// Tip: Find more about JS/TS SDKs at https://developer.kenticocloud.com/docs/javascript
const KenticoCloud = require('kentico-cloud-delivery');

// Create strongly typed models according to https://github.com/Enngage/kentico-cloud-js/blob/master/doc/delivery.md#creating-models
class Article extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
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
// DocSection: using_webhooks_get_latest_content
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

deliveryClient.item('on_roasts')
    .queryConfig({ waitForLoadingNewContent: true })
    .toObservable()
    .subscribe(response => console.log(response));

// EndDocSection
// DocSection: getting_latest_articles_get_5_articles_ord_filt
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

deliveryClient.items()
    .type('article')
    .orderParameter('elements.post_date', KenticoCloud.SortOrder.desc)
    .limitParameter(5)
    .elementsParameter(['title', 'teaser_image'])
    .getObservable()
    .subscribe(response => console.log(response));  
// EndDocSection
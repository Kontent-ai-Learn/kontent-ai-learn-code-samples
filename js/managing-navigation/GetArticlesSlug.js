// DocSection: managing_navigation_articles_slugs
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

deliveryClient.items()
  .type('article')
  .elementsParameter(['title', 'url_pattern'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
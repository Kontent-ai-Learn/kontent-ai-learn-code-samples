// DocSection: schedule_unpublishing_filter_by_date
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '14372844-0a5d-434a-8423-605b8a631623',
    typeResolvers: [
      new KontentDelivery.TypeResolver('article', (rawData) => new Article)
    ]
});

const d = new Date();
const now = d.toISOString();

deliveryClient.items()
    .type('article')
    .greaterThanFilter('elements.publish_until', now)
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
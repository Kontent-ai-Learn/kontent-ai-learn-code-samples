// DocSection: schedule_unpublishing_filter_by_date
const KenticoCloud = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KenticoCloud.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '14372844-0a5d-434a-8423-605b8a631623',
    typeResolvers: [
      new KenticoCloud.TypeResolver('article', (rawData) => new Article)
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
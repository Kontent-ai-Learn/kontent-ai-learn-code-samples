// DocSection: schedule_unpublishing_add_filter
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');
const _ = require('underscore');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
    constructor() {
        super();
    }
}

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
    typeResolvers: [
      new KontentDelivery.TypeResolver('article', (rawData) => new Article)
    ]
});

const d = new Date();
const now = d.toISOString();

deliveryClient.items()
    .type('article')
    .toObservable()
    .subscribe(response => console.log(_.filter(response.items, function (i) { 
        return ((i.ExpireAt > now || i.ExpireAt === undefined || i.ExpireAt === null))
    })));
// EndDocSection
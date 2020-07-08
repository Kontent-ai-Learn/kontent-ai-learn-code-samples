// DocSection: delivery_api_get_items_feed
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
  constructor() {
      super();
  }
}

const client = new KontentDelivery.DeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  typeResolvers: [
      new KontentDelivery.TypeResolver('article', (rawData) => new Article())
  ]
});

client.itemsFeedAll()
  .type('article')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection
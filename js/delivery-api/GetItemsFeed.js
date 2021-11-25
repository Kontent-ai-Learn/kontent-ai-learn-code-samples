// DocSection: delivery_api_get_items_feed
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
class Article extends KontentDelivery.ContentItem {
  constructor() {
      super();
  }
}

const client = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>'
});

// Gets feed of all articles in the project
const response = await client.itemsFeed()
  .type('article')
  .toAllPromise();
// EndDocSection
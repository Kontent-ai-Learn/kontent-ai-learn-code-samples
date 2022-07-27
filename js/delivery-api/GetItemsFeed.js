// DocSection: delivery_api_get_items_feed
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const client = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>'
});

// Gets feed of all articles in the project
const response = await client.itemsFeed()
  .type('article')
  .toAllPromise();
// EndDocSection
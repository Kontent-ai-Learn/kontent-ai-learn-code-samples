// DocSection: managing_navigation_articles_slugs
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

// Gets navigation items and their linked items
const rootResponse = await deliveryClient.item('root_navigation_item')
  .depthParameter(5)
  .toPromise();

// Gets specific elements of all articles
const articleResponse = await deliveryClient.items()
  .type('article')
  .elementsParameter(['title', 'url'])
  .toPromise();
// EndDocSection
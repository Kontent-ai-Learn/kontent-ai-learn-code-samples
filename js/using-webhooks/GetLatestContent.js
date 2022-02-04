// DocSection: using_webhooks_get_latest_content
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

const response = await deliveryClient.item('my_article')
  .queryConfig({ waitForLoadingNewContent: true })
  .toPromise();
// EndDocSection
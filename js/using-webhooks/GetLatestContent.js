// DocSection: using_webhooks_get_latest_content
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
});

const response = await deliveryClient.item('my_article')
  .queryConfig({ waitForLoadingNewContent: true })
  .toPromise();
// EndDocSection
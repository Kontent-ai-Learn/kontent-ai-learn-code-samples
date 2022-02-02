// DocSection: delivery_api_get_languages
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>'
});

const response = await deliveryClient.languages()
  .limitParameter(3)
  .toPromise();
// EndDocSection
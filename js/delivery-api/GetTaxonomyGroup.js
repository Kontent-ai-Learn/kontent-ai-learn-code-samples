// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>'
});

const response = await deliveryClient.taxonomy('personas')
  .toPromise();
// EndDocSection
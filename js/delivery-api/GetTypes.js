// DocSection: delivery_api_get_types
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>'
});

const response = await deliveryClient.types()
  .limitParameter(3)
  .toPromise();
// EndDocSection
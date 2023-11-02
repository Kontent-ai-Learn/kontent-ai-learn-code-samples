// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  defaultQueryConfig: {
    useSecuredMode: true, // Queries the Delivery API using secure access.
  },
  secureApiKey: '<YOUR_API_KEY>',
});

const response = await deliveryClient.item('my_article')
  .toPromise();

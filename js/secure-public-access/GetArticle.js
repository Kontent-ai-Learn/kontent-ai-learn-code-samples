// DocSection: securing_public_access_get_article
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  globalQueryConfig: {
    useSecuredMode: true, // Queries the Delivery API using secure access.
  },
  secureApiKey: '<YOUR_API_KEY>',
});

const response = await deliveryClient.item('my_article')
  .toPromise();
// EndDocSection
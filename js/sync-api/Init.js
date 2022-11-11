// DocSection: delivery_api_get_item
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>'
});

const response = await deliveryClient.initializeSync().toPromise();

// store this token in persistent storage for later use
const continuationToken = response.xContinuationToken;
// EndDocSection
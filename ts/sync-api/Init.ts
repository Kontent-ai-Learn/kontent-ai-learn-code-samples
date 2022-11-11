// DocSection: sync_api_init
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

const response = await deliveryClient.initializeSync().toPromise();

// store this token in persistent storage for later use
const continuationToken = response.xContinuationToken;
// EndDocSection
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

// Gets a feed of all articles in the project
const response = await deliveryClient.itemsFeed()
  .type('article')
  .toAllPromise();
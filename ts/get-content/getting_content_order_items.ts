// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';
import { Article } from './models/Article';

const deliveryClient = createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

const response = await deliveryClient.items<Article>()
  .type('article')
  .limitParameter(3)
  .orderParameter('system.last_modified', 'desc')
  // Or: .orderByDescending('system.last_modified')
  .toPromise();
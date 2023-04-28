// DocSection: delivery_api_get_items
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';
import { Article } from './models/Article';

const deliveryClient = createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>,
});

const response = await deliveryClient.items<Article>()
  .type('article')
  .limitParameter(3)
  .toPromise();
// EndDocSection
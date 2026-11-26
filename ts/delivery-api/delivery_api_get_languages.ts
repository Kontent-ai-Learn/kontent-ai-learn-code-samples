// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript

// @kontent-ai/delivery-sdk v16
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

const response = await deliveryClient.languages()
  .limitParameter(3)
  .toPromise();

// @kontent-ai/delivery-sdk v17
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  apiMode: 'public',
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

const response = await deliveryClient.listLanguages({ query: { limit: 3 } })
  .fetchPage();

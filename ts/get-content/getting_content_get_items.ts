// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript

// @kontent-ai/delivery-sdk v16
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.items()
    .toPromise();

// @kontent-ai/delivery-sdk v17
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  apiMode: 'public',
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.listContentItems()
    .fetchPage();

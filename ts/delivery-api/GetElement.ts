// DocSection: delivery_api_get_element
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>
});

const response = await deliveryClient.element('article', 'title')
    .toPromise();
// EndDocSection
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
    environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

// Gets feed of all strongly typed parent content items of type article for item 'my_article'
const response = await deliveryClient.itemUsedIn("my_article")
    .type('article')
    .toAllPromise();
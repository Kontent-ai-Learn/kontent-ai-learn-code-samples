// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript

// @kontent-ai/delivery-sdk v16
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
    environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

// Gets feed of all strongly typed parent content items of type article for item 'my_article'
const response = await deliveryClient.itemUsedIn("my_article")
    .type('article')
    .toAllPromise();

// @kontent-ai/delivery-sdk v17
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
    apiMode: 'public',
    environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

// Gets feed of all parent content items of type article for item 'my_article'
const { responses } = await deliveryClient.itemsReferencingItem({
    codename: 'my_article',
    filters: [{ property: 'system.type', operator: 'eq', value: 'article' }]
})
    .fetchAllPages();

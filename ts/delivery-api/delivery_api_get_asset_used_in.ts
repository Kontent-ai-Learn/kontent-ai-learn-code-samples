// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript

// @kontent-ai/delivery-sdk v16
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

// Gets feed of all strongly typed parent content items of type article for asset 'my_asset'
const response = await deliveryClient.assetUsedIn("my_asset")
  .type('article')
  .toAllPromise();

// @kontent-ai/delivery-sdk v17
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  apiMode: 'public',
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

// Gets feed of all parent content items of type article for asset 'my_asset'
const { responses } = await deliveryClient.itemsReferencingAsset({
  codename: 'my_asset',
  filters: [{ property: 'system.type', operator: 'eq', value: 'article' }]
})
  .fetchAllPages();

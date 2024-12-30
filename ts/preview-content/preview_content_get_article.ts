// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';
import { Article } from './models/Article';

const deliveryClient = createDeliveryClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  previewApiKey: 'KONTENT_AI_PREVIEW_API_KEY',
  defaultQueryConfig: {
    usePreviewMode: true, // Require Delivery Preview API
  },
});

const response = await deliveryClient.item<Article>('my_article')
  .toPromise();
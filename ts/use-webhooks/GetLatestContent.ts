// DocSection: using_webhooks_get_latest_content
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';
import { Article } from './models/Article';

const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

const response = await deliveryClient.item<Article>('my_article')
  .queryConfig({ waitForLoadingNewContent: true })
  .toPromise();
// EndDocSection
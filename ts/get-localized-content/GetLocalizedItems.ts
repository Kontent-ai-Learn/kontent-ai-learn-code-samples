// DocSection: getting_localized_content_language
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';
import { Article } from './models/Article';

const deliveryClient = createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

const response = await deliveryClient.item<Article>('about_us')
  .languageParameter('es-ES')
  .toPromise();
// EndDocSection
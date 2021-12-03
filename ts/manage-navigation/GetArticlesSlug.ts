// DocSection: managing_navigation_articles_slugs
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';
import { Article } from './models/Article';

const deliveryClient = createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

let articles: Article[];

const response = await deliveryClient.items<Article>()
  .type('article')
  .elementsParameter(['title', 'url'])
  .toPromise();

articles = response.data.items;
// EndDocSection
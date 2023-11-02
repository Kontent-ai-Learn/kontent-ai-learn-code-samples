// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';
import { Article } from './models/Article';
import { NavigationItem } from './models/NavigationItem';

const deliveryClient = createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

// Gets navigation items and their linked items
let root: NavigationItem;

const rootResponse = await deliveryClient.item<NavigationItem>('root_navigation_item')
  .depthParameter(5)
  .toPromise();

root = rootResponse.data.item;

// Gets specific elements of all articles
let articles: Article[];

const articleResponse = await deliveryClient.items<Article>()
  .type('article')
  .elementsParameter(['title', 'url'])
  .toPromise();

articles = articleResponse.data.items;

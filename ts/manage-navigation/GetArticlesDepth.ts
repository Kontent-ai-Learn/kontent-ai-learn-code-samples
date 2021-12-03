// DocSection: managing_navigation_articles_depth
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';
import { NavigationItem } from './models/NavigationItem';

const deliveryClient = createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

let root: NavigationItem;

const response = await deliveryClient.item<NavigationItem>('root_navigation_item')
  .depthParameter(5)
  .toPromise();

root = response.data.item;
// EndDocSection
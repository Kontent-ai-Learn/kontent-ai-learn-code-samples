// DocSection: managing_navigation_articles_depth
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient, TypeResolver, ContentItem, Elements } from '@kentico/kontent-delivery';
import { NavigationItem } from './models/NavigationItem';

const deliveryClient = new DeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new TypeResolver('navigation_item', (rawData) => new NavigationItem)
  ]
});

let root: NavigationItem;

deliveryClient.item<NavigationItem>('root_navigation_item')
  .depthParameter(5)
  .toObservable()
  .subscribe(response => {
    root = response.item;
    console.log(root);
  });
// EndDocSection
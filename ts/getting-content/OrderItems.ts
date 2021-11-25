// DocSection: getting_content_order_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient, SortOrder, TypeResolver } from '@kentico/kontent-delivery';
import { Article } from './models/Article';

const deliveryClient = new DeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new TypeResolver('article', (rawData) => new Article)
  ]
});

deliveryClient.items<Article>()
  .type('article')
  .limitParameter(3)
  .orderParameter('system.last_modified', SortOrder.desc)
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
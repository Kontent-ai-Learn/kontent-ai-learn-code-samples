// DocSection: delivery_api_get_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient, TypeResolver } from '@kentico/kontent-delivery';
import { Article } from './models/Article';

const deliveryClient = new DeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new TypeResolver('article', (rawData) => new Article)
  ]
});

deliveryClient.items<Article>()
  .type('article')
  .limitParameter(3)
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
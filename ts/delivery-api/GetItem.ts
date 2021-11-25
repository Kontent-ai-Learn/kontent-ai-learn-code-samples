// DocSection: delivery_api_get_item
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

deliveryClient.item<Article>('my_article')
  .toObservable()
  .subscribe(response => console.log(response.item));
// EndDocSection
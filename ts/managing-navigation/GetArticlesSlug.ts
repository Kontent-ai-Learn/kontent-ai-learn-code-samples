// DocSection: managing_navigation_articles_slugs
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient, TypeResolver } from '@kentico/kontent-delivery';
import { Article } from './models/Article';

const deliveryClient = new DeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new TypeResolver('article', (rawData) => new Article)
  ]
});

let articles: Article[];

deliveryClient.items<Article>()
  .type('article')
  .elementsParameter(['title', 'url'])
  .toObservable()
  .subscribe(response => {
    articles = response.items;
    console.log(articles);
  });
// EndDocSection
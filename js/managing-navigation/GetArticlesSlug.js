// DocSection: managing_navigation_articles_slugs
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new KontentDelivery.TypeResolver('article', (rawData) => new Article())
  ]
});

deliveryClient.items()
  .type('article')
  .elementsParameter(['title', 'url'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
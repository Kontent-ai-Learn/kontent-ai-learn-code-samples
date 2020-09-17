// DocSection: schedule_expiration_add_filter
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');
const _ = require('underscore');

const deliveryClient = new KontentDelivery.DeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new KontentDelivery.TypeResolver('landing_page', (rawData) => new LandingPage)
  ]
});

const d = new Date();
const now = d.toISOString();

deliveryClient.items()
  .type('landing_page')
  .toObservable()
  .subscribe(response => console.log(_.filter(response.items, function (i) {
    return ((i.ExpireAt > now || i.ExpireAt === undefined || i.ExpireAt === null))
  })));
// EndDocSection
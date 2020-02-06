// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '<YOUR_PROJECT_ID>'
});

deliveryClient.taxonomies()
    .limitParameter(3)
    .toObservable()
    .subscribe(response => console.log(response.taxonomies));
// EndDocSection
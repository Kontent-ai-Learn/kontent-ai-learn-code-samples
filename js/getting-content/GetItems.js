// DocSection: getting_content_get_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3'
});

deliveryClient.items()
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
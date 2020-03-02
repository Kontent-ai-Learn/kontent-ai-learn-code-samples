// DocSection: getting_content_get_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

deliveryClient.items()
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
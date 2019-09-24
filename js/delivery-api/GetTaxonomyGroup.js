// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KenticoCloud = require('@kentico/kontent-delivery');

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3'
});

deliveryClient.taxonomy('personas')
    .toObservable()
    .subscribe(response => console.log(response.taxonomy));
// EndDocSection
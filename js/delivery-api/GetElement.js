// DocSection: delivery_api_get_element
// Tip: Find more about JS/TS SDKs at https://developer.kenticocloud.com/docs/javascript
const KenticoCloud = require('kentico-cloud-delivery');

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3'
});

deliveryClient.element('coffee', 'processing')
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
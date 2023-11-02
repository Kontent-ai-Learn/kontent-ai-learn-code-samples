// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require("@kontent-ai/delivery-sdk");

const deliveryClient1 = KontentDelivery.createDeliveryClient({
  environmentId: "975bf280-fd91-488c-994c-2f04416e5ee3"
});

const deliveryClient2 = KontentDelivery.createDeliveryClient({
  environmentId: "8d20758c-d74c-4f59-ae04-ee928c0816b7"
});

const allContentItems = [];

const response1 = await deliveryClient1.items()
    .toPromise();

allContentItems.push(response1.data.items);
   
const response2 = await deliveryClient2.items()
    .toPromise();

allContentItems.push(response2.data.items);

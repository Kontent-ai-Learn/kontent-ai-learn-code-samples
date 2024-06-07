// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kontent-ai/delivery-sdk');

const deliveryClient = KontentDelivery.createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

// Gets a specific article in Spanish
const response = await deliveryClient.item('about_us')
  .languageParameter('es-ES')
  .toPromise();
// DocSection: linked_content_get_article_with_author
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

const response = await deliveryClient.item('the_origin_of_coffee')
  .depthParameter(1)
  .toPromise();
// EndDocSection
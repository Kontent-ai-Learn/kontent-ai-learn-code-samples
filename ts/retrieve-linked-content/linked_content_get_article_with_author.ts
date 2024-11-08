// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';
import { Author } from './models/Author';
import { SimpleArticle } from './models/SimpleArticle';

const deliveryClient = createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.item<SimpleArticle>('the_origin_of_coffee')
  .depthParameter(1)
  .toPromise();

const article: SimpleArticle = response.data.item;
const author: Author = article.elements.author;
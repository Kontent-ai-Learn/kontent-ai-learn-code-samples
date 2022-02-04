// DocSection: linked_content_get_article_with_author
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';
import { Author } from './models/Author';
import { SimpleArticle } from './models/SimpleArticle';

const deliveryClient = createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.item<SimpleArticle>('the_origin_of_coffee')
  .depthParameter(1)
  .toPromise();

const article: SimpleArticle = response.data.item;
const author: Author = article.elements.author;
// EndDocSection
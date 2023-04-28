// DocSection: delivery_api_get_item
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient, IContentItem, Elements } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>,
});

export type Article = IContentItem<{
  title: Elements.TextElement;
  summary: Elements.RichTextElement;
  post_date: Elements.DateTimeElement;
  teaser_image: Elements.AssetsElement;
  related_articles: Article[];
}>;

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
const response = await deliveryClient.item<Article>('my_article')
  .toPromise();
// EndDocSection
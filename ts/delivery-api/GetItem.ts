// DocSection: delivery_api_get_item
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createDeliveryClient, IContentItem, Elements } from '@kentico/kontent-delivery';

const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

export type Article = IContentItem<{
  title: Elements.TextElement;
  summary: Elements.RichTextElement;
  post_date: Elements.DateTimeElement;
  teaser_image: Elements.AssetsElement;
  related_articles: Article[];
}>;

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
const response = await deliveryClient.item<Article>('my_article')
  .toPromise();
// EndDocSection
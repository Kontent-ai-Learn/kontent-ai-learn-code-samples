// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { IContentItem, createDeliveryClient, Elements } from '@kontent-ai/delivery-sdk';

// Tip: Create strongly typed models according to https://kontent.ai/learn/tutorials/develop-apps/get-content/using-strongly-typed-models
export type Article = IContentItem<{
  title: Elements.TextElement;
  summary: Elements.RichTextElement;
  post_date: Elements.DateTimeElement;
  teaser_image: Elements.AssetsElement;
  related_articles: Article[];
}>;

const deliveryClient = createDeliveryClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  previewApiKey: 'KONTENT_AI_PREVIEW_API_KEY',
  defaultQueryConfig: {
    usePreviewMode: true, // Queries the Delivery Preview API.
  },
});

const response = await deliveryClient.item<Article>('my_article')
  .toPromise();
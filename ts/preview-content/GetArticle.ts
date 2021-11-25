// DocSection: preview_content_get_article
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { ContentItem, DeliveryClient, Elements, TypeResolver } from '@kentico/kontent-delivery';
import { Article } from './models/Article';

const deliveryClient = new DeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
  previewApiKey: '<YOUR_PREVIEW_API_KEY>',
  globalQueryConfig: {
    usePreviewMode: true, // Queries the Delivery Preview API.
  },
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new TypeResolver('article', (rawData) => new Article)
  ]
});

deliveryClient.item<Article>('my_article')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
// DocSection: delivery_api_get_item_preview
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { ContentItem, DeliveryClient, Elements, TypeResolver } from '@kentico/kontent-delivery';

// Create strongly typed models according to https://docs.kontent.ai/tutorials/develop-apps/get-content/using-strongly-typed-models
export class Article extends ContentItem {
    public title: Elements.TextElement;
    public summary: Elements.TextElement;
    public post_date: Elements.DateTimeElement;
    public teaser_image: Elements.AssetsElement;
    public related_articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    previewApiKey: '<YOUR_PREVIEW_API_KEY>',
    globalQueryConfig:  {
        usePreviewMode: true, // Queries the Delivery Preview API.
    },
    typeResolvers: [
        new TypeResolver('article', (rawData) => new Article)
    ]
});

deliveryClient.item<Article>('on_roasts')
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
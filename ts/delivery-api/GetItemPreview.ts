// DocSection: delivery_api_get_item_preview
// Tip: Find more about JS/TS SDKs at https://developer.kenticocloud.com/docs/javascript
import { ContentItem, DeliveryClient, Fields, TypeResolver } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://github.com/Enngage/kentico-cloud-js/blob/master/doc/delivery.md#creating-models
export class Article extends ContentItem {
    public title: Fields.TextField;
    public summary: Fields.TextField;
    public post_date: Fields.DateTimeField;
    public teaser_image: Fields.AssetsField;
    public related_articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    enablePreviewMode: true,
    previewApiKey: "<YOUR_PREVIEW_API_KEY>",
    typeResolvers: [
        new TypeResolver('article', () => new Article)
    ]
});

deliveryClient.item<Article>('on_roasts')
    .getObservable()
    .subscribe(response => console.log(response));
// EndDocSection
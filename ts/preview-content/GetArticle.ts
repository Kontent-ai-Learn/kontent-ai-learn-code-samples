// DocSection: preview_content_get_article
import { ContentItem, DeliveryClient, Fields, TypeResolver } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
export class Article extends ContentItem {
    public title: Fields.TextField;
    public summary: Fields.TextField;
    public post_date: Fields.DateTimeField;
    public teaser_image: Fields.AssetsField;
    public related_articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '<YOUR_PROJECT_ID>',
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
// DocSection: using_webhooks_get_latest_content
import { ContentItem, DeliveryClient, Elements, TypeResolver } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
export class Article extends ContentItem {
    public title: Elements.TextElement;
    public summary: Elements.TextElement;
    public post_date: Elements.DateTimeElement;
    public teaser_image: Elements.AssetsElement;
    public related_articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
      new TypeResolver('article', (rawData) => new Article)
    ]
});

deliveryClient.item<Article>('on_roasts')
    .queryConfig({ waitForLoadingNewContent: true })
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
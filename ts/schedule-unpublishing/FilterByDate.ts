// DocSection: schedule_unpublishing_filter_by_date
import { ContentItem, DeliveryClient, Elements, TypeResolver } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
export class Article extends ContentItem {
    public title: Elements.TextElement;
    public summary: Elements.TextElement;
    public post_date: Elements.DateTimeElement;
    public teaser_image: Elements.AssetsElement;
    public related_articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '14372844-0a5d-434a-8423-605b8a631623',
    typeResolvers: [
      new TypeResolver('article', (rawData) => new Article)
    ]
});

const d = new Date();
const now = d.toISOString();

deliveryClient.items<Article>()
    .type('article')
    .greaterThanFilter('elements.publish_until', now)
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
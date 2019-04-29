// DocSection: schedule_unpublishing_filter_by_date
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
    projectId: '14372844-0a5d-434a-8423-605b8a631623',
    typeResolvers: [
      new TypeResolver('article', () => new Article)
    ]
});

const d = new Date();
const now = d.toISOString();

deliveryClient.items<Article>()
    .type('article')
    .greaterThanFilter('elements.publish_until', now)
    .getObservable()
    .subscribe(response => console.log(response));
// EndDocSection
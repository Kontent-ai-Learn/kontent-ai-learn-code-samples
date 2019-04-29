// DocSection: schedule_unpublishing_add_filter
import { ContentItem, DeliveryClient, Fields, TypeResolver } from 'kentico-cloud-delivery';
import * as _ from 'underscore';

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
    .getObservable()
    .subscribe(response => console.log(_.filter(response.items, function (i) { 
        return ((i.PublishUntil > now || i.PublishUntil === undefined || i.PublishUntil === null))
    })));
// EndDocSection
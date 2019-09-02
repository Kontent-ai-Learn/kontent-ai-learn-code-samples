// DocSection: schedule_unpublishing_add_filter
import { ContentItem, DeliveryClient, Elements, TypeResolver } from 'kentico-cloud-delivery';
import * as _ from 'underscore';

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
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
    .toObservable()
    .subscribe(response => console.log(_.filter(response.items, function (i) { 
        return ((i.PublishUntil > now || i.PublishUntil === undefined || i.PublishUntil === null))
    })));
// EndDocSection
// DocSection: managing_navigation_articles_slugs
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

var articles: Article[];

deliveryClient.items<Article>()
  .type('article')
  .elementsParameter(['title', 'url_pattern'])
  .toObservable()
  .subscribe(response => {
    articles = response.items;
    console.log(articles);
  });
// EndDocSection
// DocSection: linked_content_get_article_with_author
import { ContentItem, DeliveryClient, Fields, TypeResolver } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
export class SimpleArticle extends ContentItem {
    public title: Fields.TextField;
    public summary: Fields.TextField;
    public post_date: Fields.DateTimeField;
    public teaser_image: Fields.AssetsField;
    public author: Author[];
}

const deliveryClient = new DeliveryClient({
    projectId: 'e6d2946e-0e24-003f-a397-9d2d458c6d6e',
    typeResolvers: [
      new TypeResolver('author', () => new Author)
    ]
});

deliveryClient.item<SimpleArticle>('the_origin_of_coffee')
    .depthParameter(1)
    .getObservable()
    .subscribe(response => console.log(response.item));
// EndDocSection
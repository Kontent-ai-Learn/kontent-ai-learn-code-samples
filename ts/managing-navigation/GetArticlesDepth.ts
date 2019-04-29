// DocSection: managing_navigation_articles_depth
import { DeliveryClient, TypeResolver, ContentItem, Fields } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
export class NavigationItem extends ContentItem {
    public title: Fields.TextField;
    public url_slug: Fields.UrlSlugField;
    public subitems: NavigationItem[];
}
  
const deliveryClient = new DeliveryClient({
    projectId: '24246f25-946d-4ab4-b170-fadef22fe7b2',
    typeResolvers: [
        new TypeResolver('navigation_item', () => new NavigationItem)
    ]
});

var root: NavigationItem;

deliveryClient.item<NavigationItem>('root_navigation_item')
  .depthParameter(5)
  .getObservable()
  .subscribe(response => {
    root = response.item;
    console.log(root);
  });
// EndDocSection
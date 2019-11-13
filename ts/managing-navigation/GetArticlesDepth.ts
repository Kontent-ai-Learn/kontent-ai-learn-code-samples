// DocSection: managing_navigation_articles_depth
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient, TypeResolver, ContentItem, Elements } from '@kentico/kontent-delivery';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
export class NavigationItem extends ContentItem {
    public title: Elements.TextElement;
    public url_slug: Elements.UrlSlugElement;
    public subitems: NavigationItem[];
}
  
const deliveryClient = new DeliveryClient({
    projectId: '24246f25-946d-4ab4-b170-fadef22fe7b2',
    typeResolvers: [
        new TypeResolver('navigation_item', (rawData) => new NavigationItem)
    ]
});

var root: NavigationItem;

deliveryClient.item<NavigationItem>('root_navigation_item')
  .depthParameter(5)
  .toObservable()
  .subscribe(response => {
    root = response.item;
    console.log(root);
  });
// EndDocSection
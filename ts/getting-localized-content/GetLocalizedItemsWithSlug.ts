// DocSection: getting_localized_content_url_slug
import { ContentItem, DeliveryClient, Fields, TypeResolver } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
import { Article } from './models/article';
export class Home extends ContentItem {
    public url_pattern: Fields.UrlSlugField;
    public contact: Fields.TextField;
    public articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
        new TypeResolver('home', () => new Home)
    ]
});

deliveryClient.items<Home>()
    .type('home')  
    .languageParameter('es-ES')
    .depthParameter(0)
    .equalsFilter('elements.url_pattern', 'inicio')
    .getObservable()
    .subscribe(response => console.log(response));
// EndDocSection
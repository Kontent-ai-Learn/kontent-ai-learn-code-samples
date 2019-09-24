// DocSection: getting_localized_content_url_slug
import { ContentItem, DeliveryClient, Elements, TypeResolver } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
import { Article } from './models/article';
export class Home extends ContentItem {
    public url_pattern: Elements.UrlSlugElement;
    public contact: Elements.TextElement;
    public articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
    typeResolvers: [
        new TypeResolver('home', (rawData) => new Home)
    ]
});

deliveryClient.items<Home>()
    .type('home')  
    .languageParameter('es-ES')
    .depthParameter(0)
    .equalsFilter('elements.url_pattern', 'inicio')
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
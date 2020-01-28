// DocSection: getting_localized_content_url_slug
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { ContentItem, DeliveryClient, Elements, TypeResolver } from '@kentico/kontent-delivery';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
import { Article } from './models/article';
export class Article extends ContentItem {
    public url_pattern: Elements.UrlSlugElement;
    public contact: Elements.TextElement;
    public articles: Article[];
}

const deliveryClient = new DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b',
    typeResolvers: [
        new TypeResolver('article', (rawData) => new Article)
    ]
});

deliveryClient.items<Article>()
    .type('article')  
    .languageParameter('es-ES')
    .depthParameter(0)
    .equalsFilter('elements.url_pattern', 'acerda-de-nosotros')
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection
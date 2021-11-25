// DocSection: securing_public_access_get_article
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { ContentItem, DeliveryClient, Elements, TypeResolver } from '@kentico/kontent-delivery';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
export class Article extends ContentItem {
	public title: Elements.TextElement;
	public summary: Elements.TextElement;
	public post_date: Elements.DateTimeElement;
	public teaser_image: Elements.AssetsElement;
	public related_articles: Article[];
}

const deliveryClient = new DeliveryClient({
	projectId: '<YOUR_PROJECT_ID>',
	globalQueryConfig: {
		useSecuredMode: true // Queries the Delivery API using secure access.
	},
	secureApiKey: '<YOUR_API_KEY>',
	typeResolvers: [new TypeResolver('article', (rawData) => new Article())]
});

deliveryClient
	.item<Article>('my_article')
	.toObservable()
	.subscribe(response => console.log(response));
// EndDocSection

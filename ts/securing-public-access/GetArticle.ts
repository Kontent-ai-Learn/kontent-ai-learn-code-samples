// DocSection: securing_public_access_get_article
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
	// globalQueryConfig sets default values for each config
	// which can be overriden by individual queries
	globalQueryConfig: {
		useSecuredMode: true // enables secured mode by default
	},
	secureApiKey: '<YOUR_API_KEY>',
	typeResolvers: [new TypeResolver('article', (rawData) => new Article())]
});

deliveryClient
	.item<Article>('on_roasts')
	.toObservable()
	.subscribe(response => console.log(response));
// EndDocSection

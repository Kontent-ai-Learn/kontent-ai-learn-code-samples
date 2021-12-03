// DocSection: securing_public_access_get_article
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { IContentItem, createDeliveryClient, Elements } from '@kentico/kontent-delivery';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
export type Article = IContentItem<{
	 title: Elements.TextElement;
	 summary: Elements.TextElement;
	 post_date: Elements.DateTimeElement;
	 teaser_image: Elements.AssetsElement;
	 related_articles: Elements.LinkedItemsElement<Article[]>;
}>;

const deliveryClient = createDeliveryClient({
	projectId: '<YOUR_PROJECT_ID>',
	globalQueryConfig: {
		useSecuredMode: true // Queries the Delivery API using secure access.
	},
	secureApiKey: '<YOUR_API_KEY>',
});

const response = await deliveryClient
	.item<Article>('my_article')
	.toPromise();
// EndDocSection

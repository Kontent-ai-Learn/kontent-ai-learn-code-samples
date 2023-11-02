// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { IContentItem, createDeliveryClient, Elements } from '@kontent-ai/delivery-sdk';

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
export type Article = IContentItem<{
	 title: Elements.TextElement;
	 summary: Elements.TextElement;
	 post_date: Elements.DateTimeElement;
	 teaser_image: Elements.AssetsElement;
	 related_articles: Elements.LinkedItemsElement<Article[]>;
}>;

const deliveryClient = createDeliveryClient({
	environmentId: '<YOUR_ENVIRONMENT_ID>',
	defaultQueryConfig: {
		useSecuredMode: true // Queries the Delivery API using secure access.
	},
	secureApiKey: '<YOUR_API_KEY>',
});

const response = await deliveryClient
	.item<Article>('my_article')
	.toPromise();

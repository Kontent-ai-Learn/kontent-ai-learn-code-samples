// DocSection: structure_in_rte_resolve_links_to_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createRichTextHtmlResolver, Elements, createDeliveryClient, linkedItemsHelper, IContentItem } from '@kentico/kontent-delivery';

// Initializes the Delivery client.
const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
export type Article = IContentItem<{
  title: Elements.TextElement;
  body: Elements.RichTextElement;
}>;

// Gets your content item.
const response = await deliveryClient.item<Article>('my_article')
  .toPromise();

// Stores the contents of the rich text element.
const richTextElement = response.data.item.body;

// Defines how to resolve the rich text element
const resolvedRichText = KontentDelivery.createRichTextHtmlResolver().resolveRichText({
  // Gives the resolver the contents of your rich text.
  element: richTextElement,
  urlResolver: (link) => {
    let url = '#unsupported-link-type';
    // Checks the content type of the linked content item
    if (link.type === 'article')
      url = `/articles/${link.urlSlug}`;
    return {
      linkUrl: url,
    };
  }
});

const resolvedHtml = resolvedRichText.html;
// EndDocSection

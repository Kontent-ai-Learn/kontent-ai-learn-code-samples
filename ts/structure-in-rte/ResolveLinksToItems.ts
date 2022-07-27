// DocSection: structure_in_rte_resolve_links_to_items
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createRichTextHtmlResolver, Elements, createDeliveryClient, linkedItemsHelper, IContentItem } from '@kontent-ai/delivery-sdk';

// Initializes the Delivery client.
const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
export type Article = IContentItem<{
  title: Elements.TextElement;
  body: Elements.RichTextElement;
}>;

// Gets your content item.
const response = await deliveryClient.item<Article>('my_article')
  .toPromise();

// Stores the contents of the rich text element.
const richTextElement = response.data.item.elements.body;

// Note: The code below executes correctly in browser. To adjust the code for nodejs, see https://kontent.ai/learn/js-rte-nodejs
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

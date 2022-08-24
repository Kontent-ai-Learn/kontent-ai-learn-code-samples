// DocSection: structure_in_rte_resolve_tweet
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createRichTextHtmlResolver, Elements, createDeliveryClient, linkedItemsHelper, IContentItem } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
export type Article = IContentItem<{
  title: Elements.TextElement;
  body: Elements.RichTextElement;
}>;

// Gets your content item with the rich text element
const response = await deliveryClient.item<Article>('my_article')
  .toPromise();

// Gets the contents of the rich text element
const richTextElement = response.data.item.elements.body;

// Note: The code below executes correctly in browser. To adjust the code for nodejs, see https://kontent.ai/learn/js-rte-nodejs
// Defines how to resolve the rich text element
const resolvedRichText = createRichTextHtmlResolver().resolveRichText({
  // Gives the resolver the contents of your rich text
  element: richTextElement,
  // Points the resolver to the content items and components that might be used in the rich text element
  linkedItems: linkedItemsHelper.convertLinkedItemsToArray(response.data.linkedItems),
  contentItemResolver: (itemId, contentItem) => {
    // For tweet items and components, resolves to the following HTML markup
    if (contentItem && contentItem.system.type === 'tweet') {
      return {
        contentItemHtml: `<blockquote class="twitter-tweet" data-lang="en" data-theme="${contentItem.elements.theme.value}"><a href="${contentItem.elements.tweetLink.value}"></a></blockquote>`
      };
    }

    // For other type of items and components, resolves to an empty string
    return {
      contentItemHtml: `<div>Unsupported type ${contentItem.system.type}</div>`
    };
  }
});

// Gets the resolved HTML content of your rich text
const resolvedRichTextHtml = resolvedRichText.html;
// EndDocSection

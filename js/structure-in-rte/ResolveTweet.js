// DocSection: structure_in_rte_resolve_tweet
const KontentDelivery = require('@kentico/kontent-delivery');

// Initializes the Delivery client.
const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

// Gets your content item.
const response = await deliveryClient.item('my_article')
  .toPromise();

// Stores the contents of the rich text element.
const richTextElement = response.data.item.elements.body;

// Note: The code below executes correctly in browser. To adjust the code for nodejs, see https://docs.kontent.ai/js-rte-nodejs.
// Defines how to resolve the rich text element
const resolvedRichText = KontentDelivery.createRichTextHtmlResolver().resolveRichText({
  // Gives the resolver the contents of your rich text.
  element: richTextElement,
  // Points the resolver to the content items and components that might be used in the rich text element.
  linkedItems: KontentDelivery.linkedItemsHelper.convertLinkedItemsToArray(response.data.linkedItems),
  contentItemResolver: (contentItem) => {
    // For tweet items and components, resolves to the following HTML markup.
    if (contentItem && contentItem.system.type === 'tweet') {
      return {
        contentItemHtml: `<blockquote class="twitter-tweet" data-lang="en" data-theme="${contentItem.elements.theme.value}"><a href="${contentItem.elements.tweetLink.value}"></a></blockquote>`
      };
    }

    // For other type of items and components, resolves to an empty string.
    return {
      contentItemHtml: `<div>Unsupported type ${contentItem.system.type}</div>`
    };
  }
});

// Gets the resolved HTML content of your rich text
const resolvedRichTextHtml = resolvedRichText.html;
// EndDocSection

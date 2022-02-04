// DocSection: structure_in_rte_resolve_links_to_items
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createRichTextHtmlResolver, Elements, createDeliveryClient, linkedItemsHelper, IContentItem } from '@kentico/kontent-delivery';

const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

export type Article = IContentItem<{
  title: Elements.TextElement;
  body: Elements.RichTextElement;
}>;

export type Author = IContentItem<{
  firstName: Elements.TextElement;
  lastName: Elements.RichTextElement;
}>;

const response = await deliveryClient.item<Article>('my_article')
  .toPromise();

// get rich text element
const richTextElement = response.data.item.body;

// resolve HTML
const resolvedRichText = createRichTextHtmlResolver().resolveRichText({
  element: richTextElement,
  linkedItems: linkedItemsHelper.convertLinkedItemsToArray(response.data.linkedItems),
  imageResolver: (image) => {
      return {
          imageHtml: `<img class="xImage" src="${image?.url}">`,
          // alternatively you may return just url
          url: 'customUrl'
      };
  },
  urlResolver: (link) => {
      return {
          linkHtml: `<a class="xLink">${link?.link?.urlSlug}</a>`,
          // alternatively you may return just url
          url: 'customUrl'
      };
  },
  contentItemResolver: (contentItem) => {
      if (contentItem && contentItem.system.type === 'Author') {
          const author = contentItem as Author;
          return {
              contentItemHtml: `<div class="xClass">${author.elements.firstName.value}</div>`
          };
      }

      return {
          contentItemHtml: ''
      };
  }
});

const resolvedHtml = resolvedRichText.html;
// EndDocSection

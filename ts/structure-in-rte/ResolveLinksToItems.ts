// DocSection: structure_in_rte_resolve_links_to_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createRichTextHtmlResolver, Elements, createDeliveryClient, linkedItemsHelper, IContentItem } from '@kentico/kontent-delivery';

const deliveryClient = createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

export type Article = IContentItem<{
  title: Elements.TextElement;
  body: Elements.RichTextElement;
}>;

const response = await deliveryClient.item<Article>('my_article')
  .toPromise();

// get rich text element
const richTextElement = response.data.item.body;

// resolve HTML
const resolvedRichText = createRichTextHtmlResolver().resolveRichText({
  element: richTextElement,
  urlResolver: (link) => {
      return {
          linkHtml: `<a>${link?.link?.urlSlug}</a>`,
          // alternatively you may return just url
          url: 'customUrl'
      };
  }
});

const resolvedHtml = resolvedRichText.html;
// EndDocSection

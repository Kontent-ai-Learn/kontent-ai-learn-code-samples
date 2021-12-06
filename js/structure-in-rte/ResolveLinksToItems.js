// DocSection: structure_in_rte_resolve_links_to_items
const KontentDelivery = require('@kentico/kontent-delivery');

// Initializes the Delivery client.
const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '<YOUR_PROJECT_ID>',
});

// Gets your content item.
const response = await deliveryClient.item('my_article')
  .toPromise();

// Stores the contents of the rich text element.
const richTextElement = response.data.item.body;

// Defines how to resolve the rich text element
const resolvedRichText = KontentDelivery.createRichTextHtmlResolver().resolveRichText({
  // Gives the resolver the contents of your rich text.
  element: richTextElement,
  urlResolver: (link) => {
    return {
      linkHtml: `<a>${link?.link?.urlSlug}</a>`,
      // alternatively you may return just url
      url: 'customUrl'
    };
  }
});


// Gets the resolved HTML content of your rich text
const resolvedRichTextHtml = resolvedRichText.html;
// EndDocSection

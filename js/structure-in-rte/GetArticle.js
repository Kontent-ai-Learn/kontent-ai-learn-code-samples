// DocSection: structure_in_rte_retrieve_article
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
    projectId: '<YOUR_PROJECT_ID>',
});

const response = await deliveryClient.item('my_article')
    .toPromise();

// get rich text element
const richTextElement = response.data.item.body;

// resolve HTML
const resolvedRichText = KontentDelivery.createRichTextHtmlResolver().resolveRichText({
    element: richTextElement,
    linkedItems: KontentDelivery.linkedItemsHelper.convertLinkedItemsToArray(response.data.linkedItems),
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
            return {
                contentItemHtml: `<div class="xClass">${contentItem.elements.firstName.value}</div>`
            };
        }

        return {
            contentItemHtml: ''
        };
    }
});

const resolvedHtml = resolvedRichText.html;
// EndDocSection

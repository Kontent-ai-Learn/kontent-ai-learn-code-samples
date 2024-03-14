// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
    environmentId: '<YOUR_ENVIRONMENT_ID>',
    apiKey: '<YOUR_API_KEY>'
});

const response = await client
    .upsertLanguageVariant()
    .byItemExternalId('simple-example')
    .byLanguageId('00000000-0000-0000-0000-000000000000')
    .withData((builder) => {
        return {
            elements: [
                builder.richTextElement({
                    element: {
                        external_id: 'rich-text'
                    },
                    value: '<h1>Lorem Ipsum</h1>\n<p>Lorem ipsum dolor sit amet, consectetur <a href="https://wikipedia.org">adipiscing elit</a>, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>\n<object type="application/kenticocloud" data-type="component" data-id="a2ee7bac-15ff-4dce-a244-012b9f98dd7b"></object>\n<p>Ut enim ad minim veniam, <a data-item-external-id="second-page">quis nostrud</a> exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>\n<ul>\n  <li>Lorem ipsum dolor sit amet</li>\n  <li>Consectetur adipiscing elit</li>\n  <li>Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</li>\n</ul><figure data-asset-external-id="rich-text-asset"></figure>',
                    components: [
                        {
                            id: 'a2ee7bac-15ff-4dce-a244-012b9f98dd7b',
                            type: {
                                external_id: 'button'
                            },
                            elements: [
                                {
                                    element: {
                                        external_id: 'button-text'
                                    },
                                    value: 'Buy me'
                                },
                                {
                                    element: {
                                        external_id: 'button-link'
                                    },
                                    value: 'https://kontent.ai'
                                }
                            ]
                        }
                    ]
                })
            ]
        };
    })
    .toPromise();
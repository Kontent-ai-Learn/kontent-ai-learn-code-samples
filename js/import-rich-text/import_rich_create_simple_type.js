// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
    environmentId: '<YOUR_ENVIRONMENT_ID>',
    apiKey: '<YOUR_API_KEY>'
});

const response = await client
    .addContentType()
    .withData((builder) => {
        return {
            external_id: 'simple-rich-text',
            name: 'Simple Rich Text',
            elements: [
                {
                    name: 'Rich Text',
                    type: 'rich_text',
                    external_id: 'rich-text'
                }
            ]
        };
    })
    .toPromise();
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
    environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
    apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
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
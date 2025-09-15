// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

// Some SDK queries are available under the `earlyAccess` namespace. 
// These APIs are in early access and may evolve before general availability. 
// Use with caution in production.
const response = await client
    .earlyAccess
    .filterLanguageVariants()
    .withData({
        filters: {
            search_phrase: 'home'
        },
        order: {
            by: 'last_modified',
            direction: 'desc'
        },
        include_content: true
    })
    .toPromise(); // or `toAllPromise()`

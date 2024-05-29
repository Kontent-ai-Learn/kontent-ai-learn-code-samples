// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
    environmentId: '<YOUR_ENVIRONMENT_ID>',
    apiKey: '<YOUR_API_KEY>'
});

const response = await client.cloneEnvironment()
    .withData(
        {
            name: "Develop",
            roles_to_activate: ["ee483b59-5a24-4010-b277-ae224c34bc71"]
        }
    )
    .toPromise();

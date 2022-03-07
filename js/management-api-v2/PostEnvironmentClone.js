// DocSection: cm_api_v2_clone_environment
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
    projectId: '<YOUR_PROJECT_ID>',
    apiKey: '<YOUR_API_KEY>'
});

const response = await client.cloneEnvironment()
    .withData(
        {
            name: "Develop",
            roles_to_activate: ["95671d8-1234-7890-ab45-1234b0b95000"]
        }
    )
    .toPromise();
// EndDocSection

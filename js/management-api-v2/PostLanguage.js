// DocSection: cm_api_v2_post_language
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addLanguage()
  .withData(
    {
      name: 'German (Germany)',
      codename: 'de-DE',
      is_active: true,
      fallback_language: {
        codename: "de-AT"
      },
      external_id: 'standard-german'
    }
  )
  .toPromise();
// EndDocSection
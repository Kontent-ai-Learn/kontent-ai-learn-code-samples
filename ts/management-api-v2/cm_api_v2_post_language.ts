// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.addLanguage()
  .withData(
    {
      name: 'German (Germany)',
      codename: 'de-DE',
      is_active: true,
      fallback_language: {
        codename: 'de-AT'
      },
      external_id: 'standard-german'
    }
  )
  .toPromise();
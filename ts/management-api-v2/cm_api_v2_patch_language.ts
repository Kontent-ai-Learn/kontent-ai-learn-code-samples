// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.modifyLanguage()
  .byLanguageId('2ea66788-d3b8-5ff5-b37e-258502e4fd5d')
  // .byLanguageCodename('de-DE')
  // .byExternalId('standard-german')
  .withData(
    [
      {
        op: 'replace',
        property_name: 'fallback_language',
        value: {
          codename: 'en-US'
        }
      },
      {
        op: 'replace',
        property_name: 'name',
        value: 'German'
      }
    ]
  )
  .toPromise();
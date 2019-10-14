// DocSection: cm_api_v2_post_language
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addLanguage()
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
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection
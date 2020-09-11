// DocSection: cm_api_v2_put_item
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Used when updating an existing item
client.updateContentItem()
  .byItemId('f4b3fc05-e988-4dae-9ac1-a94aba566474')
  // .byItemCodename('my_article')
  // .byItemExternalId('59713')
  .withData(
    {
      name: 'On Roasts',
      codename: 'my_article_my_article',
      sitemap_locations: [
        {
          codename: 'articles'
        }
      ]
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });

// Used when creating a new item or updating an existing one
client.upsertContentItem()
  .byItemExternalId('59713')
  // .byItemId('f4b3fc05-e988-4dae-9ac1-a94aba566474')
  // .byItemCodename('my_article')
  .withData(
    {
      name: 'On Roasts',
      codename: 'my_article_my_article',
      // 'type' is only required when creating a new content item
      type: 'article',
      sitemap_locations: [
        {
          codename: 'articles'
        }
      ]
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
// DocSection: import_model_create_type
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = client.addContentType()
  .withData(builder => {
    return {
      name: 'Blogpost',
      codename: 'blogpost',
      content_groups: [{
        name: 'Content',
        external_id: 'content'
      },
      {
        name: 'Metadata',
        external_id: 'metadata'
      },
      {
        name: 'Topic',
        external_id: 'topic'
      }
      ],
      elements: [
        builder.textElement({
          name: 'Title',
          type: 'text',
          content_group: {
            external_id: 'content'
          },
        }),
        builder.assetElement({
          name: 'Image',
          type: 'asset',
          content_group: {
            external_id: 'content'
          },
        }),
        builder.richTextElement({
          name: 'Blog content',
          type: 'rich_text',
          content_group: {
            external_id: 'content'
          },
        }),
        builder.snippetElement({
          snippet: {
            'codename': 'metadata'
          },
          type: 'snippet',
          codename: 'metadata',
          content_group: {
            external_id: 'metadata'
          },
        }),
        builder.taxonomyElement({
          taxonomy_group: {
            'codename': 'blog_topic'
          },
          type: 'taxonomy',
          codename: 'taxonomy',
          content_group: {
            external_id: 'topic'
          }
        })
      ]
    };
  })
  .toPromise();
// EndDocSection

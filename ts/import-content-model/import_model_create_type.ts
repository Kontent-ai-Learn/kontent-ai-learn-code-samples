// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient, ElementModels } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
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
          type: ElementModels.ElementType.text,
          content_group: {
            external_id: 'content'
          },
        }),
        builder.assetElement({
          name: 'Image',
          type: ElementModels.ElementType.asset,
          content_group: {
            external_id: 'content'
          },
        }),
        builder.richTextElement({
          name: 'Blog content',
          type: ElementModels.ElementType.richText,
          content_group: {
            external_id: 'content'
          },
        }),
        builder.snippetElement({
          snippet: {
            'codename': 'metadata'
          },
          type: ElementModels.ElementType.snippet,
          codename: 'metadata',
          content_group: {
            external_id: 'metadata'
          },
        }),
        builder.taxonomyElement({
          taxonomy_group: {
            'codename': 'blog_topic'
          },
          type: ElementModels.ElementType.taxonomy,
          codename: 'taxonomy',
          content_group: {
            external_id: 'topic'
          }
        })
      ]
    };
  })
  .toPromise();
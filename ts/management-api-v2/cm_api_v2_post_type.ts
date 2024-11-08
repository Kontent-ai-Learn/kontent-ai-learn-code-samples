// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient, ElementModels } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.addContentType()
  .withData(builder => {
    return {
      name: 'Article',
      codename: 'my_article',
      external_id: 'article',
      content_groups: [
        {
          name: 'Article copy',
          external_id: 'article-copy',
        },
        {
          name: 'Author',
          codename: 'author',
        }
      ],
      elements: [
        builder.textElement({
          name: 'Article title',
          codename: 'title',
          type: ElementModels.ElementType.text,
          content_group: {
            external_id: 'article-copy'
          },
        }),
        builder.richTextElement({
          name: 'Article body',
          codename: 'body',
          type: ElementModels.ElementType.richText,
          content_group: {
            external_id: 'article-copy'
          },
        }),
        builder.richTextElement({
          name: 'Author bio',
          codename: 'bio',
          type: ElementModels.ElementType.richText,
          allowed_blocks: [
            'images',
            'text'
          ],
          content_group: {
            codename: 'author'
          }
        })
      ]
    };
  })
  .toPromise();
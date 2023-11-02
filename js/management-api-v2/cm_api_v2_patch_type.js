// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.modifyContentType()
  .byTypeId("0be13600-e57c-577d-8108-c8d860330985")
  // .byTypeCodename("my_article")
  // .byTypeExternalId("my-article-id")
  .withData(
    [
      {
        op: "replace",
        path: "/name",
        value: "A new type name"
      },
      {
        op: "replace",
        path: "/elements/codename:my_text_element/guidelines",
        value: "Here you can tell users how to fill in the element."
      },
      {
        op: "addInto",
        path: "/elements",
        value: {
          name: "My title",
          type: "text",
          guidelines: "Title of the article in plain text.",
          external_id: "my-title-id"
        }
      },
      {
        op: "remove",
        path: "/elements/id:0b2015d0-16ae-414a-85f9-7e1a4b3a3eae"
      },
      {
        op: "remove",
        path: "/elements/external_id:my-multiple-choice-id/options/codename:my_option"
      },
      {
        op: "remove",
        path: "/elements/id:e94fab1f-c2c1-4f4a-b36c-3f7a0808d2b8/allowed_blocks/text"
      }
    ]
  )
  .toPromise();

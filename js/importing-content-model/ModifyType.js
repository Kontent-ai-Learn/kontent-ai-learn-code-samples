// DocSection: importing_modify_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
var client = new KontentManagement.ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.modifyContentType()
  // .byTypeId("0be13600-e57c-577d-8108-c8d860330985")
  .byTypeCodename("blogpost")
  // .byTypeExternalId("my-article-id")
  .withData(
    [{
        op: "addInto",
        path: "/content_groups",
        value: {
          name: 'Topic',
          external_id: 'topic'
        }
      },
      {
        op: "addInto",
        path: "/elements",
        value: {
          taxonomy_group: {
            codename: 'blog_topic'
          },
          type: 'taxonomy',
          content_group: {
            external_id: 'topic'
          }
        }
      }
    ]
  )
// EndDocSection

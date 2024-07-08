const migrationItem: MigrationItem = {
  // Variant's metadata
  system: {
    // Name the localized variant
    name: "My content item",
    // Generate a unique content item codename
    codename: "my_content_item",
    // Assign the item (and all its variants) to a collection
    collection: { codename: "default" },
    // Specify the variant's language
    language: { codename: "en_us" },
    // Specify the content type
    type: { codename: "article" },
    // Assign the variant to a workflow
    workflow: { codename: "default" },
  },
  versions: [
    {
      // Put the variant in a specific workflow step
      workflow_step: { codename: "draft" },
      elements: {
        // Variant's content
        // For each element specified by the item's content type, add properties named using element codenames.
        // Example: element_codename: elementsBuilder.textElement({ value: 'plaintext' }),
      },
    },
  ],
};

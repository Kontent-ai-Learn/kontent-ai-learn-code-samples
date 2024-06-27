const migrationItem: MigrationItem = {
  system: { // Metadata
    name: "My content item", // Name the item
    codename: "my_content_item", // Generate a unique item codename
    collection: { codename: "default" }, // Assign the item to a collection
    language: { codename: "en_us" }, // Specify the language
    type: { codename: "article" }, // Specify the item's content type
    workflow: { codename: "default" }, // Assign the item to a workflow
    workflow_step: { codename: "draft" } // Put the item in a specific workflow step
  },
  elements: { // Content
    // For elements specified by the item's content type, add properties named using element codenames.
    // Example: element_codename: elementsBuilder.textElement({ value: 'plaintext' }),
  }
};
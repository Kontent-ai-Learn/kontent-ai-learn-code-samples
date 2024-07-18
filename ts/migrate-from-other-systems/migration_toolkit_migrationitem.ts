import { MigrationItem } from "@kontent-ai/migration-toolkit";

// MigrationItem defines a localized variant of a content item
const migrationItem: MigrationItem = {
  // Variant's metadata
  system: {
    // Name the content item. Item name is shared for all variants.
    name: "My content item",
    // Generate a unique content item codename
    codename: "my_content_item",
    // Assign the item to a collection
    collection: { codename: "default" },
    // Specify the variant's language
    language: { codename: "en_us" },
    // Specify the content type
    type: { codename: "article" },
    // Assign the item to a workflow
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
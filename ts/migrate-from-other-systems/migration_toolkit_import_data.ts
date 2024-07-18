import { importAsync } from "@kontent-ai/migration-toolkit";

// Import content from the migration objects
await importAsync({
  data: {
    assets: migrationAssets,
    items: migrationItems,
  },
  environmentId: "KONTENT_AI_ENVIRONMENT_ID",
  apiKey: "MANAGEMENT_API_KEY",
});
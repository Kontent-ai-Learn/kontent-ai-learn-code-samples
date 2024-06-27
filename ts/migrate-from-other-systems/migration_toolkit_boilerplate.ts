import {
  MigrationAsset,
  MigrationItem,
  importAsync,
} from "@kontent-ai-consulting/migration-toolkit";

// 1. Map the exported content to MigrationItems
const migrationItems: MigrationItem[] = [];
// 2. Map exported files to MigrationAssets
const migrationAssets: MigrationAsset[] = [];

// 3. Import the exported and mapped data to Kontent.ai
await importAsync({
  data: {
    assets: migrationAssets,
    items: migrationItems
  },
  environmentId: "KONTENT_AI_ENVIRONMENT_ID",
  apiKey: "MANAGEMENT_API_KEY",
  skipFailedItems: false,
});
import {
  storeAsync,
} from "@kontent-ai-consulting/migration-toolkit";

// Store your mapped data on the filesystem
await storeAsync({
  data: {
    assets: migrationAssets,
    items: migrationItems
  },
  filename: 'core_content.zip',
});
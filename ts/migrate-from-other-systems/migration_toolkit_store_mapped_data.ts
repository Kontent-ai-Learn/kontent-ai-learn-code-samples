import { storeAsync } from "@kontent-ai/migration-toolkit";

// Store your mapped data on the filesystem
await storeAsync({
  data: {
    assets: migrationAssets,
    items: migrationItems,
  },
  filename: "core_content.zip",
});

import {
  ExportAdapter,
  MigrationAsset,
  MigrationItem,
  exportAsync,
  importAsync,
} from "@kontent-ai-consulting/migration-toolkit";

// Specifies how to map the exported content to migration objects
const adapter: ExportAdapter = {
  name: "customExportAdapter",
  exportAsync: () => {
    // TODO: Load the exported content and map it to MigrationItems
    const migrationItems: MigrationItem[] = [];
    // TODO: Load the exported assets and map them to MigrationAssets
    const migrationAssets: MigrationAsset[] = [];

    return {
      items: migrationItems,
      assets: migrationAssets,
    };
  },
};

// Runs the adapter to prepare exported data for import
const exportData = await exportAsync(adapter);

// Imports the exported data to a Kontent.ai environment
await importAsync({
  data: exportData,
  adapterConfig: {
    environmentId: "YOUR_ENVIRONMENT_ID",
    apiKey: "YOUR_MANAGEMENT_API_KEY",
    skipFailedItems: false,
  },
});
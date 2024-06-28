import {
    importAsync,
    extractAsync // Only when importing from stored archives
} from "@kontent-ai-consulting/migration-toolkit";

// Import from migration objects directly
await importAsync({
    data: {
        assets: migrationAssets,
        items: migrationItems
    },
    environmentId: "KONTENT_AI_ENVIRONMENT_ID",
    apiKey: "MANAGEMENT_API_KEY",
});

// Extract MigrationItem and MigrationAsset objects from archive
const { assets, items } = await extractAsync({
    filename: 'core_content.zip'
});

// Import from stored migration objects
await importAsync({
    environmentId: "KONTENT_AI_ENVIRONMENT_ID",
    apiKey: "MANAGEMENT_API_KEY",
    data: {
        assets: assets,
        items: items
    }
});


import {
    importAsync,
} from "@kontent-ai-consulting/migration-toolkit";

// Import mapped data to a specific Kontent.ai environment
await importAsync({
    data: {
        assets: migrationAssets,
        items: migrationItems
    },
    environmentId: "KONTENT_AI_ENVIRONMENT_ID",
    apiKey: "MANAGEMENT_API_KEY",
    skipFailedItems: false,
});
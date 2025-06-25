// Tip: Find more about JS SDK at https://github.com/kontent-ai/sync-sdk-js
import { getSyncClient } from "@kontent-ai/sync-sdk-js";
import { writeFile } from "fs/promises";

// Create a client with public API access
const client = getSyncClient("your-environment-id").publicApi().create();

// Sync changes using the continuation token
const { success, responses, lastContinuationToken, error } = await client
  .sync("stored-continuation-token")
  .toAllPromise();

if (!success) {
  // Handle sync error
  console.error("Failed to sync changes:", error.message);
  return;
}

// Process all responses
for (const response of responses) {
  const { items, types, languages, taxonomies } = response.payload;
  // ... handle the changes
}

// Store the last continuation token in persistent storage (fs, db, etc.) for future sync operations
await writeFile("syncApiToken", lastContinuationToken, "utf8");

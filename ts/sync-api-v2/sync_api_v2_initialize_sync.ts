// Tip: Find more about JS SDK at https://github.com/kontent-ai/sync-sdk-js
import { getSyncClient } from "@kontent-ai/sync-sdk-js";
import { writeFile } from "fs/promises";

// Create a client with public API access
const client = getSyncClient("your-environment-id").publicApi().create();

// Initialize synchronization
const { success, response, error } = await client.init().toPromise();

if (!success) {
  // Handle initialization error
  console.error("Failed to initialize sync:", error.message);
  return;
}

// Get the continuation token for future sync operations
const continuationToken = response.meta.continuationToken;

// Store the last continuation token in persistent storage (fs, db, etc.) for future sync operations
await writeFile("syncApiToken", continuationToken, "utf8");

import { MigrationAsset } from "@kontent-ai-consulting/migration-toolkit";
import { readFileSync } from "fs"; // Only if loading local data

const asset: MigrationAsset = {
  // You can load the data from anywhere, not just from the filesystem
  binaryData: readFileSync("./path/to/file.jpg"),
  // Ensure a unique asset codename. Check https://kontent.ai/learn/rules-for-codenames
  codename: "file_codename",
  // Name the binary file linked to the asset
  filename: "file.jpg",
  // Name the asset
  title: "My asset",
  // Asign the asset to a collection
  collection: {
    codename: "default",
  },
  // Specify localized asset descriptions
  descriptions: [
    {
      language: {
        codename: "default",
      },
      description: "Alt text",
    },
  ],
};

const migrationAssets: MigrationAsset[] = [asset];

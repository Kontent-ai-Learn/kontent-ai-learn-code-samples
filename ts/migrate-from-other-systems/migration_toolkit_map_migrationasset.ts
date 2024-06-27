import {
  MigrationAsset,
} from "@kontent-ai-consulting/migration-toolkit";
import { readFileSync } from "fs";

const migrationAssets: MigrationAsset[] = [];
const asset: MigrationAsset = {
  // You can load the data from anywhere, not just from the filesystem
  binaryData: readFileSync("./path/to/file.jpg"),
  codename: "file_codename", // // Generate a unique asset codename
  filename: "file.jpg", // Name the binary file linked to the asset
  title: "My asset", // Name the asset
  collection: "default",
  descriptions: [
    {
      language: {
        codename: "default"
      },
      description: "Alt text"
    }
  ]
};

migrationAssets.push(asset);
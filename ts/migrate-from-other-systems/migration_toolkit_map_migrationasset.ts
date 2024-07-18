import { MigrationAsset } from "@kontent-ai/migration-toolkit";
import { readFileSync } from "fs"; // Only if using local data

const coverAsset: MigrationAsset = {
  // You can read the data from anywhere, not just from the filesystem
  binaryData: readFileSync("./movies/posters/warrior.jpg"),
  // Ensure a unique asset codename. Check https://kontent.ai/learn/rules-for-codenames
  // This codename is used to reference the asset in the MigrationItem object
  codename: "warrior_teaser",
  // Name the binary file linked to the asset
  filename: "warrior_teaser.jpg",
  // Name the asset
  title: "Warrior cover",
  // (Optional) Asign the asset to a collection
  collection: {
    codename: "default",
  },
  // (Optional) Specify localized asset descriptions
  descriptions: [
    {
      language: {
        codename: "default",
      },
      description: "Poster for Warrior movie",
    },
  ],
};

const migrationAssets: MigrationAsset[] = [coverAsset];
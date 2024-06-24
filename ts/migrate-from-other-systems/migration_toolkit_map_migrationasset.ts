import {
  MigrationAsset,
  ExportAdapter,
} from "@kontent-ai-consulting/migration-toolkit";
import { readFileSync } from "fs";

// Adapter specifies how to map the exported content to migration objects
const adapter: ExportAdapter = {
  name: "customExportAdapter",
  exportAsync: () => {
    const sourceAssets = readFileSync("./exported-files.zip");
    const migrationAssets: MigrationAsset[] = [];

    // Example of mapping exported files to an MigrationAsset
    for (const sourceAsset of JSON.parse(sourceAssets)) {
      const asset: MigrationAsset = {
        // Identifies a file within the exported .zip archive
        _zipFilename: sourceAsset.filename,
        // Specifies the asset filename to use in Kontent.ai
        codename: toCodename(sourceAsset.filename),
        filename: sourceAsset.filename,
        // Specifies the asset title.
        title: sourceAsset.title,
        // Specifies the binary file you want to upload and use for the asset
        binaryData: readFileSync("./warrior_teaser.jpg"), // TBD
        // Specifies alt texts for the asset in multiple languages
        descriptions: [
          {
            description: sourceAsset.altText,
            language: {
              codename: toLanguage(sourceAsset.altTextLanguage)
            }
          }
        ]
      };

      migrationAssets.push(asset);
    }

    return {
      assets: migrationAssets,
    };
  },
};


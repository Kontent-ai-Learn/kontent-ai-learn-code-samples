import {
  MigrationElementModels,
  MigrationElements,
  MigrationItem,
  elementsBuilder,
  ExportAdapter,
} from "@kontent-ai-consulting/migration-toolkit";
import { readFileSync } from "fs";

// Defines the elements of the Movie content type in a Kontent.ai project
interface MovieElements extends MigrationElements {
  title: MigrationElementModels.TextElement;
  plot: MigrationElementModels.RichTextElement;
  length: MigrationElementModels.NumberElement;
  category: MigrationElementModels.MultipleChoiceElement;
  poster: MigrationElementModels.AssetElement;
}

// Defines the structure of the exported content for easier mapping
interface SourceItemModel {
  title: string;
  language: string;
  genre: string;
  text: string;
  duration: number;
}

// Load the exported content to 'fileData'
const sourceContent = readFileSync("./exported-content.json").toString();
const migrationItems: MigrationItem[] = [];

// Example of mapping a source item to a typed MigrationItem
for (const item of JSON.parse(sourceContent) as SourceItemModel[]) {
  const movie: MigrationItem<MovieElements> = {
    system: {
      name: item.title,
      // TODO: Write a custom function to transform the original title to the Kontent.ai codename format according to https://kontent.ai/learn/docs/apis/openapi/management-api-v2/#section/Rules-for-codenames
      codename: toCodename(item.title),
      collection: { codename: "default", },
      // TODO: Write a custom function to transform the source language identifier to your language codename in Kontent.ai
      language: { codename: toLanguage(item.language), },
      // Because we're migrating a single type of content, cotent type codename is hardcoded
      type: { codename: "movie", },
      workflow: { codename: "default", },
      workflow_step: { codename: "draft", },
    },
    elements: {
      title: elementsBuilder().textElement({ value: item.title }),
      length: elementsBuilder().numberElement({ value: item.duration }),
      category: elementsBuilder().multipleChoiceElement({
        value: item.genre.split(",").map((m) => {
          return { codename: m.trim() };
        }),
      }),
      // Asset element references the file by the asset codename
      poster: elementsBuilder().assetElement({
        value: [{ codename: "warrior_teaser", },],
      }),
      // The rich text content in Kontent.ai is an HTML5 fragment that contains structured content
      // See https://kontent.ai/learn/docs/apis/openapi/management-api-v2/#section/HTML5-elements-allowed-in-rich-text
      plot: elementsBuilder().richTextElement({
        value: {
          value: `<h1>${item.title}</h1><p>${item.text}</p>`,
          components: [],
        },
      }),
    },
  };

  migrationItems.push(movie);
}
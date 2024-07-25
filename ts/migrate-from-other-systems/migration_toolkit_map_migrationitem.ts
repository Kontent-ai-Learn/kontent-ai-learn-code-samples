import {
  MigrationElementModels,
  MigrationItemSystem,
  MigrationItem,
  elementsBuilder,
} from "@kontent-ai/migration-toolkit";

// We recommend you define the structure of your Kontent.ai content type
type LanguageCodenames = "default" | "en";
type CollectionCodenames = "default" | "global";
type WorkflowCodenames = "default" | "custom";
type WorkflowStepCodenames = "published" | "archived" | "draft";
type ContentTypeCodenames = "movie" | "actor";
type System<Codename extends ContentTypeCodenames> = MigrationItemSystem<
  Codename,
  LanguageCodenames,
  CollectionCodenames,
  WorkflowCodenames
>;

type MovieItem = MigrationItem<
  // Defines the elements in the 'Movie' content type defined in Kontent.ai
  {
    title: MigrationElementModels.TextElement;
    plot: MigrationElementModels.RichTextElement;
    length: MigrationElementModels.NumberElement;
    category: MigrationElementModels.MultipleChoiceElement;
    poster: MigrationElementModels.AssetElement;
    stars: MigrationElementModels.LinkedItemsElement;
    seoname: MigrationElementModels.UrlSlugElement;
    released: MigrationElementModels.DateTimeElement;
    releasecategory: MigrationElementModels.TaxonomyElement;
  },
  System<"movie">,
  WorkflowStepCodenames
>;

const movie: MovieItem = {
  system: {
    name: "Warrior",
    // Ensure a unique codename. Check https://kontent.ai/learn/rules-for-codenames
    codename: "warrior",
    collection: { codename: "default" },
    language: { codename: "default" },
    type: { codename: "movie" },
    workflow: { codename: "default" },
  },
  // Specify up to 2 versions of the variant - latest and published.
  // The latest version can be in any workflow step.
  versions: [
    {
      workflow_step: {
        // You can publish the variant during the import, or use any other workflow step
        codename: "published",
      },
      elements: {
        title: elementsBuilder.textElement({ value: "Warrior" }),
        length: elementsBuilder.numberElement({ value: 140 }),
        category: elementsBuilder.multipleChoiceElement({
          value: [
            {
              codename: "drama",
            },
            {
              codename: "action",
            },
          ],
        }),
        poster: elementsBuilder.assetElement({
          value: [
            {
              codename: "warrior_teaser",
            },
          ],
        }),
        plot: elementsBuilder.richTextElement({
          // Check allowed HTML elements in rich text value at https://kontent.ai/learn/rich-text-in-mapi
          value: {
            value: `<h1>Warrior</h1><p>...</p>`,
            components: [],
          },
        }),
        releasecategory: elementsBuilder.taxonomyElement({
          value: [
            {
              codename: "global_release",
            },
          ],
        }),
        released: elementsBuilder.dateTimeElement({
          value: "2011-09-09T00:00:00Z",
        }),
        seoname: elementsBuilder.urlSlugElement({
          // The value is empty because it's autogenerated based on a dependent text element
          value: {
            mode: "autogenerated",
            value: "",
          },
        }),
        stars: elementsBuilder.linkedItemsElement({
          value: [
            {
              codename: "tom_hardy",
            },
          ],
        }),
      },
    },
  ],
};

const migrationItems: MigrationItem[] = [movie];

import { Elements } from "@kontent-ai/delivery-sdk";
import { nodeParse, transformToPortableText, } from "@kontent-ai/rich-text-resolver";
import { PortableText, PortableTextComponents } from "@portabletext/react";
import { React } from "react";

// Defines how to transform Kontent.ai-specific portable text components, as well as default blocks
const createRichTextResolver = (element: Elements.RichTextElement): Partial<PortableTextComponents> => ({
  // The logic for individual portable text components is explained later in the lesson
  types: {
    // Resolution for components and content items inserted in rich text
    component: undefined,
    // Resolution for tables in rich text
    table: undefined,
    // Resolution for assets in rich text
    image: undefined,
  },
  marks: {
    // Resolution for links to external URLs
    link: undefined, 
    // Resolution for links to content items
    internalLink: undefined,
  },
  block: {
    // Examples of custom resolution for default blocks
    h1: undefined, // h1 headings
    p: undefined, // paragraphs
  },
});

type RichTextComponentProps = {
  richTextElement: Elements.RichTextElement;
};

// Custom React component that renders your rich text element
export const RichTextComponent: React.FC<RichTextComponentProps> = (props) => {
  // Converts a Kontent.ai rich text element value to a JSON tree
  const parsedTree = nodeParse(props.richTextElement.value);
  // Converts the JSON tree to portable text
  const portableText = transformToPortableText(parsedTree);
  // Renders content based on the specified transformations
  return (
    <PortableText
      value={portableText}
      components={createRichTextResolver(props.richTextElement)}
    />
  );
};

// In your application code, get a content item and retrieve its rich text element.
// Get familiar with retrieving content in https://kontent.ai/learn/develop/hello-world
// const richTextElement: Elements.RichTextElement = response.data.item.elements.richtext;
// Example: using 'MyComponent' to render your rich text element in a <div>
// <div>
//   <MyComponent value={richTextElement} />
// </div>
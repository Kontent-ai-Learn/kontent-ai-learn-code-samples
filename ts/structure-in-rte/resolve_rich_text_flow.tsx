import { Elements } from "@kontent-ai/delivery-sdk";
import {
  nodeParse,
  transformToPortableText,
} from "@kontent-ai/rich-text-resolver";
import { PortableText } from "@portabletext/react";

type RichTextComponentProps = {
  richTextElement: Elements.RichTextElement;
};

// Defines how to transform Kontent.ai-specific portable text components, as well as default blocks
const portableTextComponents = {
  // The logic for each portable text component is explained later in the lesson
  types: {
    component: undefined, // Components and linked items in rich text
    table: undefined, // Tables in rich text
    image: undefined, // Assets in rich text
  },
  marks: {
    link: undefined, // Links to external URLs
    internalLink: undefined, // Links to content items
  },
  block: {
    // Custom resolution for default blocks
    h1: undefined, // h1 heading
    p: undefined, // paragraph
  },
};

// Custom React component that renders your rich text element
export const RichTextComponent: React.FC<RichTextComponentProps> = (props) => {
  // Converts Kontent.ai rich text HTML to a JSON tree
  const parsedTree = nodeParse(props.richTextElement.value);
  // Converts the JSON tree to portable text
  const portableText = transformToPortableText(parsedTree);
  // Renders portable text based on the specified portable text component transformations
  return (
    <PortableText value={portableText} components={portableTextComponents} />
  );
};

// In your application code, get a content item and retrieve its rich text element.
// Get familiar with retrieving content in https://kontent.ai/learn/develop/hello-world
// const richTextElement: Elements.RichTextElement = response.data.item.elements.richtext;
// Example: using 'MyComponent' to render your rich text element in a <div>
// <div>
//   <MyComponent value={richTextElement} />
// </div>

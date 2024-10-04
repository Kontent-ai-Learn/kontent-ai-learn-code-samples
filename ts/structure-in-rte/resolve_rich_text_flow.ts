import { Elements } from '@kontent-ai/delivery-sdk';
import { nodeParse, transformToPortableText } from "@kontent-ai/rich-text-resolver"
import { PortableText, PortableTextReactComponents } from "@portabletext/react";

// Defines how to transform Kontent.ai-specific portable text components
const portableTextComponents: Partial<PortableTextReactComponents> = {
  // The logic for each portable text component is explained later in the lesson
  types: {
    component: {}, // Components in rich text
    table: {}, // Tables in rich text
    image: {} // Assets in rich text
  },
  marks: {
    link: {}, // Links to external URLs
    internalLink: {} // Links to content items
  },
}

// Custom React component that renders your rich text element
const MyComponent = ({ value }: Elements.RichTextElement) => {
  // Converts Kontent.ai rich text HTML to a JSON tree
  const parsedTree = nodeParse(value);
  // Converts the JSON tree to portable text
  const portableText = transformToPortableText(parsedTree);
  // Renders portable text based on the specified portable text component transformations
  return <PortableText value= { portableText } components = { portableTextComponents } />;
};

// In your application code, get a content item and retrieve its rich text element.
// Get familiar with retrieving content in https://kontent.ai/learn/develop/hello-world
const richTextElement: Elements.RichTextElement = response.data.item.elements.richtext;
// Example: using 'MyComponent' to render your rich text element in a <div>
// <div>
//   <MyComponent value={richTextElement} />
// </div>
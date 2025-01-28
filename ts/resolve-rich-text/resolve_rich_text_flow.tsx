import { Elements } from "@kontent-ai/delivery-sdk";
import { transformToPortableText } from "@kontent-ai/rich-text-resolver";
import { PortableText, PortableTextReactResolvers } from "@kontent-ai/rich-text-resolver/utils/react";
import { React } from "react";

// Defines how to transform Kontent.ai-specific portable text components, as well as default blocks
const createRichTextResolver = (element: Elements.RichTextElement): PortableTextReactResolvers => ({
  // The logic for individual portable text components is explained later in the lesson
  types: {
    // Resolution for components and content items inserted in rich text
    componentOrItem: undefined,
    // Resolution for tables in rich text
    table: undefined,
    // Resolution for assets in rich text
    image: undefined,
  },
  marks: {
    // Resolution for links to external URLs
    link: undefined, 
    // Resolution for links to content items
    contentItemLink: undefined,
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
  // Converts a Kontent.ai rich text element value to portable text
  const portableText = transformToPortableText(props.richTextElement.value);

  // Renders content based on the specified transformations
  return (
    <PortableText
      value={portableText}
      components={createRichTextResolver(props.richTextElement)}
    />
  );
};

// In your application code, get a content item and retrieve its rich text element.
// Tip: Learn how to get content in https://kontent.ai/learn/develop/hello-world
const richTextElement: Elements.RichTextElement = response.data.item.elements.richtext;
// Example: using 'RichTextComponent' to render your rich text
<div>
  <RichTextComponent richTextElement={richTextElement} />
</div>
import { Elements } from "@kontent-ai/delivery-sdk";
import {
  nodeParse,
  PortableTextComponent,
  transformToPortableText,
} from "@kontent-ai/rich-text-resolver";
import {
  PortableText,
  PortableTextComponents,
  PortableTextTypeComponentProps,
} from "@portabletext/react";

import { CalloutComponent } from "../components/shared/richText/Callout";
import { contentTypes } from "../models";


type RichTextComponentProps = {
  richTextElement: Elements.RichTextElement;
};

const getPortableTextComponents = (
  element: Elements.RichTextElement
): Partial<PortableTextComponents> => ({
  types: {
    component: ({
      value,
    }: PortableTextTypeComponentProps<PortableTextComponent>) => {
      const componentOrItem = element.linkedItems.find(
        (i) => i.system.codename === value.component._ref
      );

      if (!componentOrItem) {
        throw new Error("Component or item not found.");
      }

      switch (componentOrItem.system.type) {
        case contentTypes.callout.codename:
          return <CalloutComponent item={componentOrItem} />;
        default:
          return (
            <div>
              Resolution for content type {componentOrItem.system.type} not
              implemented.
            </div>
          );
      }
    },
  },
});

export const RichTextComponent: React.FC<RichTextComponentProps> = (props) => {
  const parsedTree = nodeParse(props.richTextElement.value);
  const portableText = transformToPortableText(parsedTree);
  return (
    <PortableText
      value={portableText}
      components={getPortableTextComponents(props.richTextElement)}
    />
  );
};

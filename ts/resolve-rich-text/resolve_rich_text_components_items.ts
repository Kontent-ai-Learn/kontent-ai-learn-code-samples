import { Elements } from "@kontent-ai/delivery-sdk";
import { PortableTextComponent } from "@kontent-ai/rich-text-resolver";
import { PortableTextComponents, PortableTextTypeComponentProps, } from "@portabletext/react";
import { React } from 'react';

import { CalloutComponent } from "../components/shared/richText/Callout";
import { contentTypes } from "../models";

const createRichTextResolver = (element: Elements.RichTextElement): Partial<PortableTextComponents> => ({
  types: {
    // Components and content items inserted in rich text
    component: ({
      value,
    }: PortableTextTypeComponentProps<PortableTextComponent>) => {
      // Checks if the inserted content item is included in the response
      // Kontent.ai components are always included in the response
      const componentOrItem = element.linkedItems.find(
        (i) => i.system.codename === value.component._ref
      );

      if (!componentOrItem) {
        return (<div>The inserted content item wasn't found.</div>);
      }

      // Renders the component or content item based on its type
      switch (componentOrItem.system.type) {
        // Tip: Generate models at https://kontent.ai/learn/strongly-typed-models
        case contentTypes.callout.codename:
          return <CalloutComponent item={componentOrItem} />;
        default:
          return (<div>Content based on the type '{componentOrItem.system.type}' couldn't be resolved.</div>);
      }
    },
  },
});
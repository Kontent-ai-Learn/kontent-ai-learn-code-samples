import { PortableTextMarkComponentProps, PortableTextReactComponents } from "@portabletext/react";
import {IPortableTextInternalLink} from "@kontent-ai/rich-text-resolver";

// Defines how to transform Kontent.ai-specific portable text components
const portableTextComponents: Partial<PortableTextReactComponents> = {
  marks: {
    // TODO: Explain where 'value' and 'children' come from when the transformation happens
    internalLink: ({
      value,
      children,
      // TODO: Resolve "@kontent-ai/rich-text-resolver"' has no exported member named 'IPortableTextInternalLink'?
    }: PortableTextMarkComponentProps<IPortableTextInternalLink>) => {
      // TODO: Explain where 'element' comes from
      const link = element.links.find(
        (l) => l.linkId === value?.reference._ref
      );
      if (!link) {
        throw new Error(
          "Cannot find link reference in links. This should never happen."
        );
      }
      // TODO: Show what 'InternalLink' does
      return <InternalLink link={link}>{children}</InternalLink>;
    },
  }
}
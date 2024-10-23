import { Elements, ILink } from "@kontent-ai/delivery-sdk";
import { PortableTextInternalLink } from "@kontent-ai/rich-text-resolver";
import { PortableTextComponents, PortableTextMarkComponentProps } from "@portabletext/react";
import { React, ReactNode } from "react";

import { ProductLink } from "../components";
import { contentTypes } from "../models";

type ContentItemLinkProps = {
  link: ILink;
  children: ReactNode;
};

// Custom React component for rendering links to content items
const ContentItemLink: React.FC<ContentItemLinkProps> = (props) => {
  // Use different resolution logic based on the content type
  switch (props.link.type) {
    case contentTypes.product.codename:
      return (
        <ProductLink
          itemCodename={props.link.codename}
          urlSlug={props.link.urlSlug}
        >
          {props.children}
        </ProductLink>
      );
    default:
      return (<div>Link to the content item '{props.link.codename}' couldn't be resolved.</div>);
  }
};

type ProductLinkProps = {};
const ProductLink: React.FC<ProductLinkProps> = (props) => {
  // Based on your app routing, resolve links to products
};

const createRichTextResolver = (element: Elements.RichTextElement): Partial<PortableTextComponents> => ({
  marks: {
    // Links to content items
    internalLink: ({
      value, // The linked item's metadata
      children, // Link text that might include text formatting
    }: PortableTextMarkComponentProps<PortableTextInternalLink>) => {
      // Gets content item link metadata from the response
      const link = element.links.find(
        (l) => l.linkId === value?.reference._ref
      );

      return <ContentItemLink link={link!}>{children}</ContentItemLink>;
    },
  },
});
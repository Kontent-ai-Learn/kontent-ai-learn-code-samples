// @kontent-ai/delivery-sdk v16
import { Elements, ILink } from "@kontent-ai/delivery-sdk";
import { PortableTextReactResolvers } from "@kontent-ai/rich-text-resolver-react";
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

const createRichTextResolver = (element: Elements.RichTextElement): PortableTextReactResolvers => ({
  marks: {
    // Links to content items
    contentItemLink: ({
      value, // The linked item's metadata
      children, // Link text, which might be formatted
    }) => {
      // Gets content item link metadata from the response
      const link = element.links.find(
        (l) => l.linkId === value?.contentItemLink._ref
      );

      return <ContentItemLink link={link!}>{children}</ContentItemLink>;
    },
  },
});

// @kontent-ai/delivery-sdk v17
import { Elements } from "@kontent-ai/delivery-sdk";
import { PortableTextReactResolvers } from "@kontent-ai/rich-text-resolver-react";
import { React, ReactNode } from "react";

import { ProductLink } from "../components";
import { contentTypes } from "../models";

// Metadata of a content item linked from rich text
type RichTextLink = Elements.RichText["links"][string];

type ContentItemLinkProps = {
  link: RichTextLink;
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
          urlSlug={props.link.url_slug}
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

const createRichTextResolver = (element: Elements.RichText): PortableTextReactResolvers => ({
  marks: {
    // Links to content items
    contentItemLink: ({
      value, // The linked item's metadata
      children, // Link text, which might be formatted
    }) => {
      // Gets content item link metadata from the response. The links are keyed by the linked item's ID.
      const link = value && element.links[value.contentItemLink._ref];

      return <ContentItemLink link={link!}>{children}</ContentItemLink>;
    },
  },
});

import { Elements, ILink } from "@kontent-ai/delivery-sdk";
import {
  nodeParse,
  PortableTextInternalLink,
  transformToPortableText,
} from "@kontent-ai/rich-text-resolver";
import {
  PortableText,
  PortableTextComponents,
  PortableTextMarkComponentProps,
} from "@portabletext/react";
import { ReactNode } from "react";

import { ProductLink } from "../components";
import { contentTypes } from "../models";

type RichTextComponentProps = {
  richTextElement: Elements.RichTextElement;
};

type ItemLinkProps = {
  link: ILink;
  children: ReactNode;
};

type ProductLinkProps = {};

const getPortableTextComponents = (
  element: Elements.RichTextElement
): Partial<PortableTextComponents> => ({
  marks: {
    internalLink: ({
      value,
      children,
    }: PortableTextMarkComponentProps<PortableTextInternalLink>) => {
      const link = element.links.find(
        (l) => l.linkId === value?.reference._ref
      );

      return <ItemLink link={link!}>{children}</ItemLink>;
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

const ItemLink: React.FC<ItemLinkProps> = (props) => {
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
      throw new Error(
        `No resolution implemented for item links of type ${props.link.type}.`
      );
  }
};

const ProductLink: React.FC<ProductLinkProps> = (props) => {
  // implementation of ProductLink component
};

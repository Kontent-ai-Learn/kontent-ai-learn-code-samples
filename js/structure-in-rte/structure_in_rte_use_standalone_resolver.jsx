import React from "react";
import { PortableText, toPlainText } from "@portabletext/react";
import { nodeParse, transformToPortableText } from "@kontent-ai/rich-text-resolver"
import { resolveImage, resolveTable, toHTMLImageDefault } from "@kontent-ai/rich-text-resolver/utils/html";

const richTextElement = {/* rich text element from SDK response */}

/**
 * object, defining resolution for various portable text objects.
 * to be passed into <PortableText> component.
 */
const portableTextComponents = {
    types: {
      // resolution for component custom block, representing linked items/components in rich text content
      component: ({ value }) => {
        const item = richTextElement.linkedItems.find(item => item.system.codename === value.component._ref);
        return <div>{item?.elements.text_element.value}</div>;
      },
      // resolution for tables in rich text.
      // makes use of resolveTable helper method included in the package.
      table: ({ value }) => {
        const tableString = resolveTable(value, toPlainText);
        return <>{tableString}</>;
      },
      // resolution for assets in rich text.
      // makes use of resolveImage helper method included in the package.
      image: ({ value }) => {
        const imageString = resolveImage(value, toHTMLImageDefault);
        return <>{imageString}</>;
      }
    },
    marks: {
      // resolution for links to external URLs
      link: ({ value, children }) => {
        const target = (value?.href || '').startsWith('http') ? '_blank' : undefined
        return (
          <a href={value?.href} target={target} rel={value?.rel} title={value?.title} data-new-window={value?.['data-new-window']}>
            {children}
          </a>
        )
      },
      // resolution for links to content items
      internalLink: ({ value, children }) => {
        const item = richTextElement.linkedItems.find(item => item.system.id === value?.reference._ref);
        return (
          <a href={"https://website.xyz/" + item?.system.codename}>
            {children}
          </a>
        )
      }
    },
    block: {
      /**
       * custom resolution for h1 tag. this specific example showcases anchor creation.
       * 
       * createAnchorString can return e.g. a sanitized, url-friendly text content
       * of the heading or any other string representing the anchor.
       * 
       * all default tags/blocks can be overridden in this manner.
       */
      h1: ({ value, children }) => (
        <h1 id={createAnchorString(value)}>
          <a href={`#${createAnchorString(value)}`}>{children}</a>
        </h1>
      ),
    },
  }

  // custom component rendering the resolved rich text
  const MyComponent = ({ props }) => {
    // https://github.com/portabletext/react-portabletext#customizing-components
  
    const parsedTree = nodeParse(props.element.value); // or browserParse, converts HTML to JSON tree
    const portableText = transformToPortableText(parsedTree); // converts JSON tree to portable text
  
    return (
      /**
       * component from @portabletext/react package.
       * accepts an array of portable text blocks and the `components` object which
       * defines resolution for individual portable text entities.
       */
      <PortableText value={portableText} components={portableTextComponents} />
    );
  };
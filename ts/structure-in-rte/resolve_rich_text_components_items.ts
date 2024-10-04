import { PortableTextComponent, PortableTextReactComponents, PortableTextTypeComponentProps } from "@portabletext/react";

// Defines how to transform Kontent.ai-specific portable text components
const portableTextComponents: Partial<PortableTextReactComponents> = {
  // The specific logic for each component is explained later in the lesson
  types: {
    component: ({
      value,
    }: PortableTextTypeComponentProps<PortableTextComponent>) => {
      // TODO: Specify where 'element' comes from
      const componentOrItem = element.linkedItems.find(
        (i) => i.system.codename === value.component._ref
      );

      if (!componentOrItem) {
        throw new Error(
          "Content item wasn't found. Check your request depth."
        );
      }

      // Renders specific React components based on the content type
      switch (componentOrItem.system.type) {
        // Check https://kontent.ai/learn/strongly-typed-models to create content type models
        case contentTypes.callout.codename:
          return <CalloutComponent item={componentItem as Component_Callout} />;
        case contentTypes.action.codename:
          return <CTAButton reference={componentItem as Action} />;
        case contentTypes.content_chunk.codename:
          return <ContentChunk item={componentItem as Block_ContentChunk} />;
        default:
          return `Unsupported content type &quot;${componentItem.system.type}&quot;`
      }
    }
  }
}
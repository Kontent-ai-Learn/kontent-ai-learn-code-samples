// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
import { IContentItem, Elements } from '@kontent-ai/delivery-sdk';

export type Author = IContentItem<{
    name: Elements.TextElement;
    bio: Elements.RichTextElement;
}>;

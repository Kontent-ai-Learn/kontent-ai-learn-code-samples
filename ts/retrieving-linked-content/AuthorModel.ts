// DocSection: linked_content_author_model
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
import { IContentItem, Elements } from '@kentico/kontent-delivery';

export type Author = IContentItem<{
    name: Elements.TextElement;
    bio: Elements.RichTextElement;
}>;
// EndDocSection
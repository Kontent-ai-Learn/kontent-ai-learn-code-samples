// DocSection: linked_content_simple_article_model
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { IContentItem, Elements } from '@kentico/kontent-delivery';
import { Author } from './models/author';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
export type SimpleArticle = IContentItem<{
   title: Elements.TextElement;
   body: Elements.RichTextElement;
   author: Elements.LinkedItemsElement<Author>[];
}>;
// EndDocSection
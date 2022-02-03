// DocSection: linked_content_simple_article_model
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { IContentItem, Elements } from '@kentico/kontent-delivery';
import { Author } from './models/author';

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
export type SimpleArticle = IContentItem<{
   title: Elements.TextElement;
   body: Elements.RichTextElement;
   author: Elements.LinkedItemsElement<Author>[];
}>;
// EndDocSection
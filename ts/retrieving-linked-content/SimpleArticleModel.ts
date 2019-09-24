// DocSection: linked_content_simple_article_model
import { ContentItem, Elements } from '@kentico/kontent-delivery';

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models

export class SimpleArticle extends ContentItem {
    public title: Elements.TextElement;
    public body: Elements.RichTextElement;
    public author: ContentItem[];
}
// EndDocSection
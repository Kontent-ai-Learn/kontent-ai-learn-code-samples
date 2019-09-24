// DocSection: linked_content_author_model
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models

import { ContentItem, Elements } from 'kentico-cloud-delivery';

export class Author extends ContentItem {
    public name: Elements.TextElement;
    public bio: Elements.RichTextElement;
}
// EndDocSection
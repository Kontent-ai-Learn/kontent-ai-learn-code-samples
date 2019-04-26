// DocSection: linked_content_author_model
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models

import { ContentItem, Fields } from 'kentico-cloud-delivery';

export class Author extends ContentItem {
    public name: Fields.TextField;
    public bio: Fields.RichTextField;
}
// EndDocSection
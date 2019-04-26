// DocSection: linked_content_simple_article_model
import { ContentItem, Fields } from 'kentico-cloud-delivery';

// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models

export class SimpleArticle extends ContentItem {
    public title: Fields.TextField;
    public body: Fields.RichTextField;
    public author: ContentItem[];
}
// EndDocSection
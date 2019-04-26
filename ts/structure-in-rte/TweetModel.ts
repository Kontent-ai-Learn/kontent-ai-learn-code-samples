// DocSection: structure_in_rte_tweet_model
import { ContentItem, Fields } from 'kentico-cloud-delivery';

// Generate strongly typed models at https://github.com/Kentico/kentico-cloud-js/tree/master/packages/model-generator

export class Tweet extends ContentItem {
    public tweetLink: Fields.TextField;
    public theme: Fields.MultipleChoiceField;
    public displayOptions: Fields.MultipleChoiceField;
    constructor() {
        super({
            propertyResolver: (fieldName: string) => {
                if (fieldName === 'tweet_link') {
                    return 'tweetLink';
                }
                if (fieldName === 'display_options') {
                    return 'displayOptions';
                }
                return fieldName;
            }
        });
    }
}
// EndDocSection
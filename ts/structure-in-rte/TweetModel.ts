// DocSection: structure_in_rte_tweet_model
import { ContentItem, Elements } from '@kentico/kontent-delivery';

// Generate strongly typed models at https://github.com/Kentico/kentico-cloud-js/tree/master/packages/model-generator

export class Tweet extends ContentItem {
    public tweetLink: Elements.TextElement;
    public theme: Elements.MultipleChoiceElement;
    public displayOptions: Elements.MultipleChoiceElement;
    constructor() {
        super({
            propertyResolver: (elementName: string) => {
                if (elementName === 'tweet_link') {
                    return 'tweetLink';
                }
                if (elementName === 'display_options') {
                    return 'displayOptions';
                }
                return elementName;
            }
        });
    }
}
// EndDocSection
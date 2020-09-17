// DocSection: structure_in_rte_tweet_model
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { ContentItem, Elements } from '@kentico/kontent-delivery';

// Generate strongly typed models at https://github.com/Kentico/kontent-model-generator-js
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
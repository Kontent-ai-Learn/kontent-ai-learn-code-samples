// DocSection: structure_in_rte_implement_resolver
// This is a global resolver for all tweets. You can also define a resolver for a given query: https://github.com/Kentico/kentico-cloud-js/blob/master/packages/delivery/DOCS.md#locally-per-query

import { ContentItem, Fields } from 'kentico-cloud-delivery';

export class Tweet extends ContentItem {

  ...
  
  constructor() {
    super({
      
      ...
      
      richTextResolver: (item: Tweet, context) => {
        return `<blockquote class="twitter-tweet" data-lang="en" data-theme="${item.theme.value}"><a href="${item.tweetLink.text}"></a></blockquote>`;
      }
    })
  }
}
// EndDocSection
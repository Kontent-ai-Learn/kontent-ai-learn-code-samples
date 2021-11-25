// DocSection: structure_in_rte_implement_resolver
// This is a global resolver for all tweets. You can also define a resolver for a given query: https://docs.kontent.ai/js-resolve-query
import { ContentItem } from '@kentico/kontent-delivery';

export class Tweet extends ContentItem {
  constructor() {
    super({
      richTextResolver: (item: Tweet, context) => {
        return `<blockquote class='twitter-tweet' data-lang='en' data-theme='${item.theme.value}'><a href='${item.tweetLink.value}'></a></blockquote>`;
      }
    })
  }
}
// EndDocSection
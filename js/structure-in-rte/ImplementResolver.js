// DocSection: structure_in_rte_implement_resolver
// This is a global resolver for all tweets. You can also define a resolver for a given query: https://github.com/Kentico/kentico-kontent-js/blob/master/packages/delivery/DOCS.md#locally-per-query

class Tweet extends ContentItem {
    constructor() {
        super({
            richTextResolver: (tweet) => {
                return `<blockquote class='twitter-tweet' data-lang='en' data-theme='`+tweet.theme.value[0].codename+`'><a href='`+tweet.tweet_link.value+`'></a></blockquote>`;
            }
        })
    }
}         

var typeResolvers = [
    new TypeResolver('tweet', (rawData) => new Tweet())
];
// EndDocSection
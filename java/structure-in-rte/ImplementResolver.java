// DocSection: structure_in_rte_implement_resolver
package com.github.kentico.kontent.delivery;

public class TweetInlineContentItemsResolver extends InlineContentItemsResolver<Tweet> {
    @Override
    String resolve() {
        return "<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"" + tweet.theme[0].codename + "\"><a href=\"" + tweet.tweetLink.url + "\"></a></blockquote>"
    }
}
// EndDocSection
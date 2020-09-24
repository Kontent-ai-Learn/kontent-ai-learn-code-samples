// DocSection: structure_in_rte_implement_resolver
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
public class TweetInlineContentItemsResolver extends InlineContentItemsResolver<Tweet> {
    @Override
    String resolve() {
        return "<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"" + tweet.theme[0].codename + "\"><a href=\"" + tweet.tweetLink.url + "\"></a></blockquote>"
    }
}
// EndDocSection
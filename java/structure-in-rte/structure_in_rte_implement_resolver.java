// Tip: Find more about Java SDK at https://kontent.ai/learn/java
public class TweetInlineContentItemsResolver extends InlineContentItemsResolver<Tweet> {
    @Override
    String resolve() {
        return "<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"" + tweet.theme[0].codename + "\"><a href=\"" + tweet.tweetLink.url + "\"></a></blockquote>"
    }
}

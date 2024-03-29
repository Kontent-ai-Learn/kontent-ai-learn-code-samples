public class TweetResolver : IInlineContentItemsResolver<Tweet>
    {
        public string Resolve(Tweet data)
        {
            return
                $"<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"{data.Theme}\"><a href=\"{data.TweetLink}\"></a></blockquote>";
        }
    }

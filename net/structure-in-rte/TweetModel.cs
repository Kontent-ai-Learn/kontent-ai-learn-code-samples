// DocSection: structure_in_rte_tweet_model
// Generate strongly typed models at https://github.com/Kentico/kontent-generators-net

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace KenticoKontentModels
{
    public partial class Tweet
    {
        public const string Codename = "tweet";
        public const string TweetLinkCodename = "tweet_link";
        public const string ThemeCodename = "theme";
        public const string DisplayOptionsCodename = "display_options";

        public string TweetLink { get; set; }
        public IEnumerable<MultipleChoiceOption> Theme { get; set; }
        public IEnumerable<MultipleChoiceOption> DisplayOptions { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}
// EndDocSection

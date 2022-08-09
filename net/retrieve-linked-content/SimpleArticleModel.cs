// DocSection: linked_content_simple_article_model
// Create strongly typed models according to https://kontent.ai/learn/net-strong-types

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiModels
{
    public partial class SimpleArticle
    {
        public const string Codename = "simple_article";
        public const string TitleCodename = "title";
        public const string BodyCodename = "body";
        public const string AuthorCodename = "author";

        public string Title { get; set; }
        public string Body { get; set; }
        public IEnumerable<object> Author { get; set; }
        public IContentItemSystemAttributes System { get; set; }
    }
}
// EndDocSection

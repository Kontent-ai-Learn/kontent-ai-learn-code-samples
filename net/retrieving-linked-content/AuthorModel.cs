// DocSection: linked_content_author_model
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery;

namespace KenticoKontentModels
{
    public partial class Author
    {
        public const string Codename = "author";
        public const string NameCodename = "name";
        public const string BioCodename = "bio";

        public string Name { get; set; }
        public IRichTextContent Bio { get; set; }
    }
}
// EndDocSection
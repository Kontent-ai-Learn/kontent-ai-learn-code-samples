// Create strongly typed models according to https://kontent.ai/learn/net-strong-types

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiModels
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

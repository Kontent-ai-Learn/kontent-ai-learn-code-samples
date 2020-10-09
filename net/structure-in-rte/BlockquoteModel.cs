// DocSection: structure_in_rte_blockquote_model
// Generate strongly typed models at https://github.com/Kentico/kontent-generators-net

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace KenticoKontentModels
{
    public partial class Blockquote
    {
        public const string Codename = "blockquote";
        public const string QuoteCodename = "quote";
        public const string SourceCodename = "source";

        public IRichTextContent Quote { get; set; }
        public string Source { get; set; }
        public IContentItemSystemAttributes System { get; set; }
    }
}
// EndDocSection

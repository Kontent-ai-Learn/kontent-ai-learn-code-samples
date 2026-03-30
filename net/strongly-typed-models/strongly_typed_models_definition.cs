using System.Collections.Generic;
using System.Text.Json.Serialization;
using Kontent.Ai.Delivery.Attributes;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiModels
{
    [ContentTypeCodename("homepage")]
    public record Homepage
    {
        [JsonPropertyName("body_text")]
        public RichTextContent? BodyText { get; init; }

        [JsonPropertyName("headline")]
        public string? Headline { get; init; }

        [JsonPropertyName("picture")]
        public IEnumerable<IAsset>? Picture { get; init; }
    }
}
#nullable enable

using System.Text.Json.Serialization;
using Kontent.Ai.Delivery.Attributes;
using Kontent.Ai.Delivery.ContentItems.RichText;

// Tip: Generate models via https://github.com/kontent-ai/dotnet/tree/main/src/model-generator

namespace KontentAiModels;

// Identifies this record as the Author content type for the SDK's type resolution
[ContentTypeCodename("author")]
public partial record Author
{
    // Stores the codename of each element for use in queries and switch expressions
    public const string NameCodename = "name";
    public const string BioCodename = "bio";

    public const string ContentTypeCodename = "author";

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("bio")]
    public RichTextContent? Bio { get; init; }
}

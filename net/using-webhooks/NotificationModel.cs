// DocSection: using_webhooks_notification_model
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using System;
using Newtonsoft.Json;

public class KenticoCloudWebhookModel
{
    [JsonProperty("message")]
    public Message Message { get; set; }

    [JsonProperty("data")]
    public Data Data { get; set; }
}

public class Message
{
    [JsonProperty("id")]
    public Guid Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("operation")]
    public string Operation { get; set; }

    [JsonProperty("api_name")]
    public string ApiName { get; set; }

    [JsonProperty("project_id")]
    public Guid ProjectId { get; set; }
}

public class Data
{
    [JsonProperty("items")]
    public Item[] Items { get; set; }

    [JsonProperty("taxonomies")]
    public Taxonomy[] Taxonomies { get; set; }
}

public class Item
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("codename")]
    public string Codename { get; set; }
    
    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}

public class Taxonomy
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("codename")]
    public string Codename { get; set; }
}
// EndDocSection
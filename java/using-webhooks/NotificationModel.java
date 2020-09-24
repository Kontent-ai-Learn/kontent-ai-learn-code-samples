// DocSection: using_webhooks_notification_model
// Tip: Find more about Java SDKs at https://docs.kontent.ai/java
import com.fasterxml.jackson.annotation.JsonProperty;

public class KenticoKontentWebhookModel {
    @JsonProperty("message")
    Message message;

    @JsonProperty("data")
    Data data;

    public Message getMessage() { return message; }

    public Data getData() { return data; }
}

public class Message {
    @JsonProperty("id")
    String id;

    @JsonProperty("type")
    String type;

    @JsonProperty("operation")
    String operation;

    @JsonProperty("api_name")
    String apiName;

    @JsonProperty("project_id")
    String projectId;

    public String getId { return id; }

    public String getType { return type; }

    public String getOperation { return operation; }

    public String getApiName { return apiName; }

    public String getProjectId { return projectId; }
}

public class Data {
    @JsonProperty("items")
    List<Item> items;

    @JsonProperty("taxonomies")
    List<Taxonomy> taxonomies;

    public List<Item> getItems { return items; }

    public List<Taxonomy> getTaxonomies { return taxonomies; }
}

public class Item {
    @JsonProperty("id")
    String id;

    @JsonProperty("codename")
    String codename;

    @JsonProperty("language")
    String language;

    @JsonProperty("type")
    String type;

    public String getId { return id; }

    public String getCodename { return codename; }
    
    public String getLanguage { return language; }

    public String getType { return type; }
}

public class Taxonomy {
    @JsonProperty("id")
    String id;

    @JsonProperty("codename")
    String codename;

    public String getId { return id; }

    public String getCodename { return codename; }
}
// EndDocSection
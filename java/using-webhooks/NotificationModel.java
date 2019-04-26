// DocSection: using_webhooks_notification_model
import com.fasterxml.jackson.annotation.JsonProperty;

public class KenticoCloudWebhookModel {
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
    @JsonProperty("language")
    String language;

    @JsonProperty("type")
    String type;

    @JsonProperty("codename")
    String codename;

    public String getLanguage { return language; }

    public String getType { return type; }

    public String getCodename { return codename; }
}

public class Taxonomy {
    @JsonProperty("codename")
    String codename;

    public String getCodename { return codename; }
}
// EndDocSection
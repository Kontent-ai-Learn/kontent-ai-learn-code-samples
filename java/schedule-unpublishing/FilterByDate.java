// DocSection: schedule_unpublishing_filter_by_date
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("14372844-0a5d-434a-8423-605b8a631623");

TimeZone tz = TimeZone.getTimeZone("UTC");
DateFormat df = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm'Z'");
df.setTimeZone(tz);
String now = df.format(new Date());

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .filterGreaterThan("elements.publish_until", now)
    .build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
List<ArticleItem> items = client.getItems(ArticleItem.class, params);
// EndDocSection
// DocSection: schedule_unpublishing_update_model
public final class Article extends ContentItem {

  public static final String TYPE = "article";

  public Date getPublishUntil() {
    return publishUntil.getValue();
  }
  
  ...
}
// EndDocSection
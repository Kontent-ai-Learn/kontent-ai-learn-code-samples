// DocSection: schedule_unpublishing_update_model
public final class LandingPage extends ContentItem {

  public static final String TYPE = "landing_page";

  public Date getExpireAt() {
    return ExpireAt.getValue();
  }
  
  ...
}
// EndDocSection
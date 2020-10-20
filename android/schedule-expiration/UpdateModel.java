// DocSection: schedule_expiration_update_model
@ContentItemMapping("landing_page")
public class LandingPage {

  // ...

  @ElementMapping("expire_at")
    ZonedDateTime expireAt;

  // ...

  public ZonedDateTime getExpireAt() {
    return expireAt;
  }
  
  // ...
}
// EndDocSection
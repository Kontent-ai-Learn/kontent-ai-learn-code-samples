// DocSection: schedule_unpublishing_update_model
@ElementMapping("publish_until")
ZonedDateTime ExpireAt;

public ZonedDateTime getExpireAt() {
  	return ExpireAt;
}

public void setExpireAt(ZonedDateTime ExpireAt) {
  	this.ExpireAt = ExpireAt;
}
// EndDocSection
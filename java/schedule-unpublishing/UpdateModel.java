// DocSection: schedule_unpublishing_update_model
@ElementMapping("expire_at")
ZonedDateTime ExpireAt;

public ZonedDateTime getExpireAt() {
  	return ExpireAt;
}

public void setExpireAt(ZonedDateTime ExpireAt) {
  	this.ExpireAt = ExpireAt;
}
// EndDocSection
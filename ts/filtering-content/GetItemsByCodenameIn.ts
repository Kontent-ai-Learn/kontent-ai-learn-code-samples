// DocSection: filtering_get_items_by_codename_in
// Gets three items by their codenames. The codenames are unique per project.
deliveryClient.items<ContentItem>()
  .inFilter('system.codename', ['delivery_api', 'get_content', 'hello_world'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
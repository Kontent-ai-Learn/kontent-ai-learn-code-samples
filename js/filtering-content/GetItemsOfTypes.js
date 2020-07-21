// DocSection: filtering_get_items_of_types
deliveryClient.items()
  // Gets items of following content types
  .inFilter("system.type", ["product"], ["article"], ["news"])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
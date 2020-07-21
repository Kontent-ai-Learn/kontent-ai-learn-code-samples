// DocSection: filtering_get_items_of_types
deliveryClient.items()
  // Gets items based on the type Product, Article, and News
  .inFilter("system.type", ["product"], ["article"], ["news"])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
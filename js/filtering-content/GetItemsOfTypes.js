// DocSection: filtering_get_items_of_types
// Gets items based on the type Product, Article, and News
deliveryClient.items()
  .inFilter('system.type', ['product', 'article', 'news'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
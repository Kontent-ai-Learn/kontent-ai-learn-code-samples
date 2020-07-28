// DocSection: filtering_get_items_of_types
// Gets items based on the types Product, Article, and News
deliveryClient.items<ContentItem>()
  .inFilter('system.type', ['product', 'article', 'news'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
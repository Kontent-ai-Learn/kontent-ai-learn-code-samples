// DocSection: filtering_get_items_of_types
// Gets items based on the type Product, Article, and News
const response = await deliveryClient.items()
  .inFilter('system.type', ['product', 'article', 'news'])
  .toPromise();
// EndDocSection
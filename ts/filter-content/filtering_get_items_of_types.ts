// Gets items based on the types Product, Article, and News
const itemsByTypes = await deliveryClient.items()
  .inFilter('system.type', ['product', 'article', 'news'])
  .toPromise();
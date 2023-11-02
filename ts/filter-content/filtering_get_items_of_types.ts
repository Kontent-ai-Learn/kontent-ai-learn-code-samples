// Gets items based on the types Product, Article, and News
const response = await deliveryClient.items()
  .inFilter('system.type', ['product', 'article', 'news'])
  .toPromise();

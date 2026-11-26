// @kontent-ai/delivery-sdk v16
// Gets items based on the types Product, Article, and News
const itemsByTypes = await deliveryClient.items()
  .inFilter('system.type', ['product', 'article', 'news'])
  .toPromise();

// @kontent-ai/delivery-sdk v17
// Gets items based on the types Product, Article, and News
const itemsByTypes = await deliveryClient.listContentItems({
  filters: [{ property: 'system.type', operator: 'in', value: ['product', 'article', 'news'] }]
})
  .fetchPage();

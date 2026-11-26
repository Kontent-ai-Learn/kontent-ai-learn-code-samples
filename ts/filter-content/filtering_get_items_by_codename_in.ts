// @kontent-ai/delivery-sdk v16
// Gets three items by their codenames. The codenames are unique per project
const itemsByCodenames = await deliveryClient.items()
  .inFilter('system.codename', ['delivery_api', 'get_content', 'hello_world'])
  .toPromise();

// @kontent-ai/delivery-sdk v17
// Gets three items by their codenames. The codenames are unique per project
const itemsByCodenames = await deliveryClient.listContentItems({
  filters: [{ property: 'system.codename', operator: 'in', value: ['delivery_api', 'get_content', 'hello_world'] }]
})
  .fetchPage();

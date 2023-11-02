// Gets three items by their codenames. The codenames are unique per project.
const response = await deliveryClient.items()
  .inFilter('system.codename', ['delivery_api', 'get_content', 'hello_world'])
  .toPromise();

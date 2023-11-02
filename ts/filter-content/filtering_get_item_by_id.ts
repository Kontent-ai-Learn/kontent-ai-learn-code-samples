// Gets an item by its internal ID
const response = await deliveryClient.items()
  .equalsFilter('system.id', '2f7288a1-cfc8-47be-9bf1-b1d312f7da18')
  .toPromise();

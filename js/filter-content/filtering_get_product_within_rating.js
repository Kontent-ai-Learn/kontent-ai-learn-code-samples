// Gets items whose rating is at least 6.5 and at most 9
const response = await deliveryClient.items()
  .rangeFilter('elements.product_rating', '6.5', '9')
  .toPromise();

// DocSection: filtering_get_product_within_rating
// Gets items whose rating is at least 6.5 and at most 9
deliveryClient.items<ContentItem>()
  .rangeFilter("elements.product_rating", "6.5", "9")
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
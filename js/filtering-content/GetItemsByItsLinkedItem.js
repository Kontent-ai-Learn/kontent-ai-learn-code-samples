// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane.
deliveryClient.items()
  .containsFilter('elements.author', ['jane_doe'])
  .toObservable()
  .subscribe(response => console.log(response));

// Gets items attributed to at least Jane, John, or both.
deliveryClient.items()
  .anyFilter('elements.author', ['jane_doe', 'john_wick'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
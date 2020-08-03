// DocSection: filtering_get_items_by_linked_item
// Gets items attributed to Jane. Matched items may also reference other authors.
deliveryClient.items()
  .containsFilter('elements.author', ['jane_doe'])
  .toObservable()
  .subscribe(response => console.log(response));

// Gets items attributed to at least Jane, John, or both. Matched items may also reference other authors.
deliveryClient.items()
  .anyFilter('elements.author', ['jane_doe', 'john_wick'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
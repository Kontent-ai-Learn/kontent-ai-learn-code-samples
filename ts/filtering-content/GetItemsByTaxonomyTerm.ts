// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
deliveryClient.items<ContentItem>()
  .containsFilter('elements.tags', ['kontent'])
  .toObservable()
  .subscribe(response => console.log(response));

// Gets items tagged with a list of specific tags
deliveryClient.items<ContentItem>()
  .allFilter('elements.tags', ['kontent', 'headless'])
  .toObservable()
  .subscribe(response => console.log(response));

// Gets items tagged with at least one tag from the list
deliveryClient.items<ContentItem>()
  .anyFilter('elements.tags', ['football', 'soccer'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection
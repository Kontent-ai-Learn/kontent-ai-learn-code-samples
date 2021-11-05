// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
const response = await deliveryClient.items()
  .containsFilter('elements.tags', ['kontent'])
  .toPromise();

// Gets items tagged with a list of specific tags
const response = await deliveryClient.items()
  .allFilter('elements.tags', ['kontent', 'headless'])
  .toPromise();

// Gets items tagged with at least one tag from the list
const response = await deliveryClient.items()
  .anyFilter('elements.tags', ['football', 'soccer'])
  .toPromise();
// EndDocSection
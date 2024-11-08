// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
const itemsByTag = await deliveryClient.items()
  .containsFilter('elements.tags', ['kontent_ai'])
  .toPromise();

// Gets items tagged with a list of specific tags
const itemsByAllTags = await deliveryClient.items()
  .allFilter('elements.tags', ['kontent_ai', 'cms'])
  .toPromise();

// Gets items tagged with at least one tag from the list
const itemsByAnyTag = await deliveryClient.items()
  .anyFilter('elements.tags', ['headless', 'cms'])
  .toPromise();
// @kontent-ai/delivery-sdk v16
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

// @kontent-ai/delivery-sdk v17
// Note: Filters work with codenames of the tags.
// Gets items tagged with one specific tag
const itemsByTag = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.tags', operator: 'contains', value: 'kontent_ai' }]
})
  .fetchPage();

// Gets items tagged with a list of specific tags
const itemsByAllTags = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.tags', operator: 'all', value: ['kontent_ai', 'cms'] }]
})
  .fetchPage();

// Gets items tagged with at least one tag from the list
const itemsByAnyTag = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.tags', operator: 'any', value: ['headless', 'cms'] }]
})
  .fetchPage();

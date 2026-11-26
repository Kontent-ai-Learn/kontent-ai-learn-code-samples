// @kontent-ai/delivery-sdk v16
// Gets items in default language with the URL slug element equal to 'sample-url-slug'
const itemsByUrlSlug = await deliveryClient.items()
  .equalsFilter('elements.url_slug', 'sample-url-slug')
  .toPromise();

// @kontent-ai/delivery-sdk v17
// Gets items in default language with the URL slug element equal to 'sample-url-slug'
const itemsByUrlSlug = await deliveryClient.listContentItems({
  filters: [{ property: 'elements.url_slug', operator: 'eq', value: 'sample-url-slug' }]
})
  .fetchPage();

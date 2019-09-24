// DocSection: structure_in_rte_retrieve_article
import { ContentItem, Elements, TypeResolver } from '@kentico/kontent-delivery';

deliveryClient.item<Article>('coffee_beverages_explained')
  .toObservable()
  .subscribe(response => {
    console.log(response.item.body.resolveHtml());
  });
// EndDocSection

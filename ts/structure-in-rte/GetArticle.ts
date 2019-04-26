// DocSection: structure_in_rte_retrieve_article
import { ContentItem, Fields, TypeResolver } from 'kentico-cloud-delivery';

deliveryClient.item<Article>('the_origin_of_coffee')
  .getObservable()
  .subscribe(response => {
    console.log(response.item.body.getHtml());
  });
// EndDocSection
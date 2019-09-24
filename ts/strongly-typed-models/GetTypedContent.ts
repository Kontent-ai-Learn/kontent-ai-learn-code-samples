// DocSection: strongly_typed_models_retrieve
import { ContentItem, DeliveryClient, Elements, SortOrder, TypeResolver } from '@kentico/kontent-delivery';

import { Homepage } from './models/homepage';

// Creates an instance of the Delivery client and registers your model in type resolvers
const deliveryClient = new DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
    typeResolvers: [
        new TypeResolver('homepage', (rawData) => new Homepage)
    ]
});

var homepage: Homepage;

// Gets a content item from Kentico Cloud by its codename and maps it to its strongly typed model
deliveryClient.item<Homepage>('hello_headless_world')
  .toObservable()
  .subscribe(response => {
    homepage = response.item;
    // Use homepage;
    // console.log(homepage.headline.value);
  });
// EndDocSection
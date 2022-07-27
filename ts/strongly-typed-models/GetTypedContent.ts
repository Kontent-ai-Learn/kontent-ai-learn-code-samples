// DocSection: strongly_typed_models_retrieve
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

import { Homepage } from './models/homepage';

// Initializes the Delivery client and registers your model in type resolvers
const deliveryClient = createDeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

var homepage: Homepage;

// Gets an item by codename from Kontent.ai and maps it to a strongly typed model
const response = await deliveryClient.item<Homepage>('hello_caas_world')
  .toPromise();

homepage = response.data.item;
// EndDocSection
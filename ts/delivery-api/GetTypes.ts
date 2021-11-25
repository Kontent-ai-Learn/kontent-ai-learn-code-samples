// DocSection: delivery_api_get_types
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient } from '@kentico/kontent-delivery';

const deliveryClient = new DeliveryClient({
  projectId: '<YOUR_PROJECT_ID>'
});

deliveryClient.types()
  .limitParameter(3)
  .toObservable()
  .subscribe(response => console.log(response.types));
// EndDocSection
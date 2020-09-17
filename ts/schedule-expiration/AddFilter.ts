// DocSection: schedule_expiration_add_filter
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { DeliveryClient, TypeResolver } from '@kentico/kontent-delivery';
import * as _ from 'underscore';
import { LandingPage } from './models/LandingPage';

const deliveryClient = new DeliveryClient({
    projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
    typeResolvers: [
      new TypeResolver('landing_page', (rawData) => new LandingPage)
    ]
});

const d = new Date();
const now = d.toISOString();

deliveryClient.items<LandingPage>()
    .type('landing_page')
    .toObservable()
    .subscribe(response => console.log(_.filter(response.items, function (i) { 
        return ((i.ExpireAt > now || i.ExpireAt === undefined || i.ExpireAt === null))
    })));
// EndDocSection
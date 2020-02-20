// DocSection: schedule_expiration_update_model
export class LandingPage extends KontentDelivery.ContentItem {
    constructor(){
         super({
             propertyResolver: ((elementName) => {
                 if (elementName === 'expire_at'){
                     return 'ExpireAt';
                 }
               
                 ...
             }),
         })
     }
 }
// EndDocSection
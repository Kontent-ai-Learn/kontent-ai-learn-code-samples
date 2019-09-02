// DocSection: schedule_unpublishing_update_model
export class Article extends KenticoCloud.ContentItem {
    constructor(){
         super({
             propertyResolver: ((elementName) => {
                 if (elementName === 'publish_until'){
                     return 'publishUntil';
                 }
               
                 ...
             }),
         })
     }
 }
// EndDocSection
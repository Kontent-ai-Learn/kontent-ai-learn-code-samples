// DocSection: schedule_unpublishing_update_model
export class Article extends KenticoCloud.ContentItem {
    constructor(){
         super({
             propertyResolver: ((fieldName) => {
                 if (fieldName === 'publish_until'){
                     return 'publishUntil';
                 }
               
                 ...
             }),
         })
     }
 }
// EndDocSection